using Cinemachine.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    public PlayerMove movement;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement.Speed = 5;
        }
        else
            movement.Speed = 3;
    }
}
