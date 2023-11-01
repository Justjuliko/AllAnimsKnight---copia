using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCollectionable : MonoBehaviour
{
    public Minigame minigame;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            minigame.counterCollected();
            Destroy(gameObject);
        }
    }
}
