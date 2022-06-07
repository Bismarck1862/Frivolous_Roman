using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int value = 1;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddAmmo(value);
            audioSource.Play();
            Statics.Ammo1 += 10;

            Destroy(gameObject);
        }
    }
}
