using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public AudioSource shootSound;
    public AudioSource emptySound;

    public Camera cam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Statics.IsGameActive)
        {
            if(Statics.ActiveWeapon == 1 && Statics.Ammo1 > 0){
                Shoot(1f, 50f);
            }else if (Statics.ActiveWeapon == 2 && Statics.Ammo2 > 0)
            {
                Shoot(2f, 100f);
            }
            else
            {
                emptySound.Play();
            }
        }
    }

    void Shoot(float damage, float range)
    {
        shootSound.Play();
        if(Statics.ActiveWeapon == 1)Statics.Ammo1 -= 1;
        if(Statics.ActiveWeapon == 2) Statics.Ammo2 -= 1;


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
            /*Debug.Log(cam.transform.position.ToString() + " " + cam.transform.forward.ToString());*/
        }
    }
}
