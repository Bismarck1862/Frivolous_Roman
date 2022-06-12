using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo2Pickup : MonoBehaviour
{
    public int value = 1;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddAmmo2(value);
            audioSource.Play();
            //Statics.Ammo2 += 10;

            Destroy(gameObject);
        }
    }
}
