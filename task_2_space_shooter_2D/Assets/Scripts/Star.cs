using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int livesToAdd = 1; // Qo'shiladigan hayot miqdori
    public GameObject pickupEffect; // Zarracha effekti

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Tag yordamida tekshirish
        {
            // Jon qo'shish
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.AddLife(livesToAdd); // Hayotni qo'shish
                Debug.Log("Life added!");


                // Ovoz
                GetComponent<AudioSource>().Play();

                // Zarracha effekti
                if (pickupEffect != null)
                {
                    Instantiate(pickupEffect, transform.position, Quaternion.identity);
                }
                // Ob'ektni yo'q qilish
                Destroy(gameObject);
            }
        }
    }
}
