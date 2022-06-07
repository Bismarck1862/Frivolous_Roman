using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidPickup : MonoBehaviour
{
    public int value = 1;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddAidKit(value);
            audioSource.Play();
            Statics.HeroLifes += 1;

            Destroy(gameObject);
        }
    }
}
