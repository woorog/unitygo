using UnityEngine;
using Unity.Netcode;
public class ClientGameManager : MonoBehaviour
{
    public static ClientGameManager Instance;

    public Sprite[] tileSprites; // 서버와 동일한 타일 스프라이트 배열
    private GameObject[] tiles;  // 타일 오브젝트 배열

    private void Awake()
    {
        Instance = this;

        tiles = new GameObject[14];
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i] = GameObject.Find($"Tile_{i}");
            if (tiles[i] != null)
            {
                SpriteRenderer renderer = tiles[i].GetComponent<SpriteRenderer>();
                if (renderer != null)
                {
                    renderer.sprite = null;
                }
                else
                {
                    Debug.LogWarning($"[클라이언트] Tile_{i}에 SpriteRenderer가 없습니다.");
                }
            }
            else
            {
                Debug.LogWarning($"[클라이언트] Tile_{i}를 찾을 수 없습니다.");
            }
        }
    }

    private void Start()
    {
        if (NetworkManager.Singleton != null && NetworkManager.Singleton.IsClient)
        {
            ServerGameManager.Instance.RequestTileDataServerRpc();
        }
        else
        {
            Debug.LogError("[클라이언트] 서버에 연결되지 않았습니다.");
        }
    }

    public void UpdateTileSprite(int tileId, int spriteIndex)
    {
        if (tileId < 0 || tileId >= tiles.Length || spriteIndex < 0 || spriteIndex >= tileSprites.Length)
        {
            Debug.LogError($"[클라이언트] 잘못된 데이터: 타일 ID = {tileId}, 스프라이트 인덱스 = {spriteIndex}");
            return;
        }

        GameObject tile = tiles[tileId];
        if (tile != null)
        {
            SpriteRenderer renderer = tile.GetComponent<SpriteRenderer>();
            if (renderer != null)
            {
                renderer.sprite = tileSprites[spriteIndex];
                Debug.Log($"[클라이언트] 타일 {tileId}에 스프라이트 {spriteIndex} 적용 완료.");
            }
            else
            {
                Debug.LogWarning($"[클라이언트] 타일 {tileId}에 SpriteRenderer가 없습니다.");
            }
        }
        else
        {
            Debug.LogWarning($"[클라이언트] 타일 {tileId}를 찾을 수 없습니다.");
        }
    }
}
