using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LobbyUI : MonoBehaviour
{
    public Button joinButton;
    public Button exitButton;
    public Transform content; // Content 오브젝트
    public GameObject playerPrefab; // PlayerText Prefab

    private void Start()
    {
        joinButton.onClick.AddListener(() => AddPlayer($"Player {content.childCount + 1}"));
        exitButton.onClick.AddListener(RemoveLastPlayer);
    }

    private void AddPlayer(string playerName)
    {
        GameObject newPlayer = Instantiate(playerPrefab, content);
        TMP_Text playerText = newPlayer.GetComponent<TMP_Text>();
        if (playerText != null)
        {
            playerText.text = playerName;
        }
    }

    private void RemoveLastPlayer()
    {
        if (content.childCount > 0)
        {
            Transform lastPlayer = content.GetChild(content.childCount - 1);
            Destroy(lastPlayer.gameObject);
        }
    }
}
