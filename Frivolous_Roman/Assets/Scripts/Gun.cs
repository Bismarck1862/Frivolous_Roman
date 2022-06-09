using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Settings")]
    public float damage = 10f;
    public float range = 100f;

    public AudioSource shootSound;
    public AudioSource emptySound;

    public Camera cam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(Statics.Ammo1 > 0){
                Shoot();
            }
            else
            {
                emptySound.Play();
            }
        }
    }

    void Shoot()
    {
        shootSound.Play();
        Statics.Ammo1 -= 1;


        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
        else
        {
            Debug.Log(cam.transform.position.ToString() + " " + cam.transform.forward.ToString());
        }
    }
}
