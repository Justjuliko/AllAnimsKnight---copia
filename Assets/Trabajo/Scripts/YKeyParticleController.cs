using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YKeyParticleController : MonoBehaviour
{
    public ParticleSystem MparticleSystem; // Reference to the Particle System for the Y key

    void Start()
    {
        MparticleSystem.Stop(); // Stop the particle system initially
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Play the Y key particle system when the Y key is pressed
            MparticleSystem.Play();
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            // Stop the Y key particle system when the Y key is released
            MparticleSystem.Stop();
        }
    }
}
