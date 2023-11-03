using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public Animator _CharacterAnimatorMago;
    public Animator _CharacterAnimatorMaga;

    public GameObject destroyableGameObject;

    [SerializeField] int counter = 0;

    bool interact = false;
    private void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            interact = true;
        }
        else
        {
            interact= false;
        }
    }
    public void counterCollected()
    {
        counter++;
    }
    private void OnTriggerStay(Collider other)
    {
        if (interact == true) 
        {
            if (counter < 3)
            {
                _CharacterAnimatorMago.SetBool("pushheavyobj", true);
                _CharacterAnimatorMaga.SetBool("pushheavyobj", true);
            }
            else if(counter == 3)
            {
                _CharacterAnimatorMago.SetBool("pushobj", true);
                _CharacterAnimatorMaga.SetBool("pushobj", true);
                destroyableGameObject.SetActive(false);
            }
        }
        else if (interact == false)
        {
            _CharacterAnimatorMago.SetBool("pushobj", false);
            _CharacterAnimatorMaga.SetBool("pushobj", false);
            _CharacterAnimatorMago.SetBool("pushheavyobj", false);
            _CharacterAnimatorMaga.SetBool("pushheavyobj", false);
        }
    }
}
