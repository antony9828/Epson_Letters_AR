using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicNetwork : MonoBehaviour
{ 

    public bool start;

    public Player player1;
    public Player player2;

    private bool oneTime = false;
    
    // Start is called before the first frame update
    void Start()
    {
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.players.Count == 2)
        {
            start = true;
        } else
        {
            start = false;
        }

        if (start && !oneTime)
        {
            player1 = GameManager.playersList[0];
            player2 = GameManager.playersList[1];
            player1.myTurn = true;
            player2.myTurn = false;
            oneTime = true;
        }

        
    }

    public void Switch()
    {
        player1.myTurn = !player1.myTurn;
        player2.myTurn = !player2.myTurn;

        Debug.Log("Switch client");
    }
}
