using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

[RequireComponent(typeof(PlayerSetup))]
public class Player : NetworkBehaviour
{
    [SyncVar]
    public bool myTurn;

    private void Update()
    {
        if (!isLocalPlayer)
            return;

        if (Input.GetKeyDown(KeyCode.Space) && myTurn)
        {
            Logic.next_count++;
            if (Logic.next_count >= 3)
                Logic.next_count = 0;
            CmdSwitchTurn();
        }
    }

    [Command]
    void CmdSwitchTurn()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<LogicNetwork>().Switch();
        //Debug.Log("Switch Server");
    }
}
