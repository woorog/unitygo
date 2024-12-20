using Unity.Netcode;
using UnityEngine;

public class TileClickHandler : MonoBehaviour
{
    // public int TileId; // Inspector에서 설정할 타일 ID

    // private void OnMouseDown()
    // {
    //     Debug.Log($"[클라이언트] 타일 {TileId} 클릭. 서버로 전송 시도.");

    //     if (NetworkManager.Singleton != null && NetworkManager.Singleton.IsClient)
    //     {
    //         ServerGameManager.Instance.HandleTileClickServerRpc(TileId);
    //     }
    //     else
    //     {
    //         Debug.LogError("[클라이언트] 서버에 연결되지 않았거나 서버가 실행 중이 아닙니다.");
    //     }
    // }
}
