using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    int player = 1;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.K))
        {
            player++;
            ChangePlayer();
        }
    }

    private void ChangePlayer()
    {
        if (player == 1)
        {
            Player1.SetActive(true);
            Player2.SetActive(false);
        }
        if (player == 2)
        {
            Player1.SetActive(false);
            Player2.SetActive(true);
            player = 0;
        }
    }
}
