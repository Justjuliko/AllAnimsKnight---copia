using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacebarParticleController : MonoBehaviour
{
    public ParticleSystem myparticleSystem; // Reference to the Particle System for the spacebar

    void Start()
    {
        myparticleSystem.Stop(); // Stop the particle system initially
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the spacebar particle system when the spacebar is pressed
            myparticleSystem.Play();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Stop the spacebar particle system when the spacebar is released
            myparticleSystem.Stop();
        }
    }
}
