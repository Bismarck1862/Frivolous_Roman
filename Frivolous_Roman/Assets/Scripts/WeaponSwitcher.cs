using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Statics.IsGameActive)
        {
            switchWeapons();
        }
    }

    void switchWeapons()
    {
        int counter = 1;
        foreach (Transform weapon in transform)
        {
            weapon.gameObject.SetActive(!weapon.gameObject.activeSelf);
            if (!weapon.gameObject.activeSelf)
            {
                Statics.ActiveWeapon = counter;
            }
            counter += 1;
        }
    }
}
