using Unity.Netcode;
using UnityEngine;

public class NetworkButtonManager : MonoBehaviour
{
    // 서버 시작 버튼에 연결될 메서드
    public void StartServer()
    {
        Debug.Log("[네트워크] 서버 시작");
        NetworkManager.Singleton.StartServer();

        if (ServerGameManager.Instance != null)
        {
            ServerGameManager.Instance.InitializeTiles();
        }
    }

    // 클라이언트 시작 버튼에 연결될 메서드
    public void StartClient()
    {
        Debug.Log("[네트워크] 클라이언트 시작");
        NetworkManager.Singleton.StartClient();

        NetworkManager.Singleton.OnClientConnectedCallback += (clientId) =>
        {
            Debug.Log($"[클라이언트] 서버와 연결됨. 클라이언트 ID: {clientId}");
            if (NetworkManager.Singleton.IsClient)
            {
                ServerGameManager.Instance.RequestTileDataServerRpc();
            }
        };
    }
}
