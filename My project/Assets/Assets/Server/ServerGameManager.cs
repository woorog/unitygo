using Unity.Netcode;
using System.Collections.Generic;
using UnityEngine;

public class ServerGameManager : NetworkBehaviour
{
    public static ServerGameManager Instance;

    public Sprite[] tileSprites; // 타일 스프라이트 배열
    private Dictionary<int, int> tileSpriteMapping = new Dictionary<int, int>();

private void Awake()
{
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    else
    {
        Destroy(this.gameObject);
    }
}

    public void InitializeTiles()
    {
        tileSpriteMapping.Clear();

        if (tileSprites == null || tileSprites.Length == 0)
        {
            Debug.LogError("[서버] 타일 스프라이트가 설정되지 않았습니다.");
            return;
        }

        for (int i = 0; i < 14; i++)
        {
            int randomIndex = Random.Range(0, tileSprites.Length);
            tileSpriteMapping[i] = randomIndex;
        }

        Debug.Log($"[서버] 타일 초기화 완료. 총 {tileSpriteMapping.Count}개의 타일.");
        BroadcastTileStates();
    }

    private void BroadcastTileStates()
    {
        foreach (var tile in tileSpriteMapping)
        {
            if (tile.Key < 0 || tile.Key >= 14 || tile.Value < 0 || tile.Value >= tileSprites.Length)
            {
                Debug.LogError($"[서버] 잘못된 타일 데이터: {tile.Key}, {tile.Value}");
                continue;
            }

            SetTileSpriteClientRpc(tile.Key, tile.Value);
        }
    }

[ClientRpc]
private void SetTileSpriteClientRpc(int tileId, int spriteIndex, ClientRpcParams clientRpcParams = default)
{
    Debug.Log($"[서버 -> 클라이언트] 타일 ID: {tileId}, 스프라이트 인덱스: {spriteIndex} 수신.");
    if (ClientGameManager.Instance == null)
    {
        Debug.LogError("[서버 -> 클라이언트] ClientGameManager.Instance가 null입니다.");
        return;
    }

    ClientGameManager.Instance.UpdateTileSprite(tileId, spriteIndex);
}


    [ServerRpc(RequireOwnership = false)]
    public void RequestTileDataServerRpc(ServerRpcParams rpcParams = default)
    {
        Debug.Log($"[서버] 클라이언트 {rpcParams.Receive.SenderClientId}가 타일 데이터를 요청했습니다.");
        BroadcastTileStates();
    }
}