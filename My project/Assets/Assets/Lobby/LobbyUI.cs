using Mirror;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LobbyUI : NetworkBehaviour
{
    public Button joinButton;
    public Button exitButton;
    public Transform content; // Content 오브젝트
    public GameObject playerPrefab; // PlayerText Prefab

    [SyncVar] // 서버-클라이언트 동기화를 위한 변수
    public string playerName;

    private void Start()
    {
        if (isLocalPlayer)
        {
            joinButton.onClick.AddListener(JoinLobby);
            exitButton.onClick.AddListener(RemoveLastPlayer);
        }
    }

    [Command] // 클라이언트 → 서버로 요청
    private void CmdAddPlayer(string playerName)
    {
        RpcAddPlayer(playerName); // 서버 → 모든 클라이언트로 브로드캐스트
    }

    [ClientRpc] // 서버 → 모든 클라이언트
    private void RpcAddPlayer(string playerName)
    {
        GameObject newPlayer = Instantiate(playerPrefab, content);
        TMP_Text playerText = newPlayer.GetComponent<TMP_Text>();
        if (playerText != null)
        {
            playerText.text = playerName;
        }
    }

    private void JoinLobby()
    {
        if (isLocalPlayer)
        {
            CmdAddPlayer($"Player {content.childCount + 1}");
        }
    }

    private void RemoveLastPlayer()
    {
        if (isLocalPlayer && content.childCount > 0)
        {
            Transform lastPlayer = content.GetChild(content.childCount - 1);
            Destroy(lastPlayer.gameObject);
        }
    }
}
