using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int healthToAdd = 1; // Qo'shiladigan jon miqdori
    public GameObject pickupEffect; // Zarracha effekti

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            // Jon qo'shish
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.ReceiveHealing(healthToAdd); // ReceiveHealing methodini chaqirish
                Debug.Log("Health added!");

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
