using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    [SerializeField] int counter = 0;

    public void counterCollected()
    {
        counter++;
    }
}
