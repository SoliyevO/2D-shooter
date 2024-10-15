using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{


     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Debug.Log("Run");
            GetComponent<AudioSource>().Play();

            // Jon qo'shish
            // Ovoz
            // Particle
            // Destroy
        }
    }
}
