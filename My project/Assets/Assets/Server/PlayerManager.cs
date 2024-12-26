using UnityEngine;
using System.Collections.Generic;
using Mirror;
using System.Collections; // 추가된 올바른 네임스페이스

using UnityEngine.UI;

public class PlayerManager : NetworkBehaviour
{
    public GameObject[] cardPrefabs; // 카드 프리팹 배열
    public GameObject MyArea;       // 내 패 배치 영역
    public GameObject ClientArea;   // 상대 패 배치 영역
    public GameObject DisCard;      // 내 버림패 영역
    public GameObject ClientDiscard;// 상대 버림패 영역

    private List<GameObject> myCards = new List<GameObject>();        // 내 마작패 리스트

    public override void OnStartClient()
    {
        base.OnStartClient();

        // 각 영역을 동적으로 할당
        MyArea = GameObject.Find("MyArea");
        ClientArea = GameObject.Find("ClientArea");
        DisCard = GameObject.Find("DisCard");
        ClientDiscard = GameObject.Find("ClientDiscard");
    }

    [Server]
    public override void OnStartServer()
    {
        base.OnStartServer();
        for (int i = 0; i < 9; i++)
        {
            myCards.Add(cardPrefabs[i]);
        }

        Debug.Log(myCards);
    }

    [Command]
    public void CmdDealCards()
    {
        for (int i = 0; i < 14; i++)
        {
            // 카드 생성
            GameObject card = Instantiate(myCards[Random.Range(0, myCards.Count)], Vector3.zero, Quaternion.identity);
            NetworkServer.Spawn(card, connectionToClient);

            // 카드에 클릭 이벤트 추가
            Button cardButton = card.GetComponent<Button>();
            if (cardButton == null)
            {
                cardButton = card.AddComponent<Button>();
            }
            cardButton.onClick.AddListener(() => CmdDiscardCard(card));

            // 클라이언트로 RPC 호출 (소유권 검증)
            RpcShowCards(card, connectionToClient == NetworkServer.localConnection);
        }
    }

    [Command]
    public void CmdDiscardCard(GameObject card)
    {
        RpcDiscardCard(card, connectionToClient == NetworkServer.localConnection);
    }

    [ClientRpc]
    void RpcShowCards(GameObject card, bool isMine)
    {
        // 위치와 크기 초기화
        card.transform.localPosition = Vector3.zero;
        card.transform.localScale = Vector3.one;

        // 부모 설정
        if (isMine)
        {
            card.transform.SetParent(MyArea.transform, false);
        }
        else
        {
            card.transform.SetParent(ClientArea.transform, false);

            // 상대 카드도 클릭 이벤트 허용
            Button cardButton = card.GetComponent<Button>();
            if (cardButton == null)
            {
                cardButton = card.AddComponent<Button>();
            }
            cardButton.onClick.AddListener(() => CmdDiscardCard(card));
        }
    }

    [ClientRpc]
    void RpcDiscardCard(GameObject card, bool isMine)
    {
        // 위치와 크기 초기화
        card.transform.localPosition = Vector3.zero;
        card.transform.localScale = Vector3.one;

        // 부모 설정
        if (isMine)
        {
            card.transform.SetParent(DisCard.transform, false);
        }
        else
        {
            card.transform.SetParent(ClientDiscard.transform, false);
        }
    }
}
