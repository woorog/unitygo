using UnityEngine;
using Mirror;
using System.Collections;
using System.Collections.Generic;

public class DrawTile :NetworkBehaviour
{
    public PlayerManager PlayerManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnClick()
    {
        NetworkIdentity networkIdentity = NetworkClient.connection.identity;
        PlayerManager = networkIdentity.GetComponent<PlayerManager>();
        PlayerManager.CmdDealCards();

    }
}
