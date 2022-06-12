using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD_Controller : MonoBehaviour
{
    public TMP_Text ammo;
    public Image image;
    public Sprite riffle;
    public Sprite handGun;

    void Start()
    {
        if (Statics.ActiveWeapon == 2)
        {
            ammo.text = Statics.Ammo2.ToString();
            image.sprite = riffle;
        }

        if (Statics.ActiveWeapon == 1)
        {
            ammo.text = Statics.Ammo1.ToString();
            image.sprite = handGun;
        }
    }

    void Update()
    {
        if (Statics.ActiveWeapon == 2)
        {
            ammo.text = Statics.Ammo2.ToString();
            image.sprite = riffle;
        }

        if (Statics.ActiveWeapon == 1)
        {
            ammo.text = Statics.Ammo1.ToString();
            image.sprite = handGun;
        }
    }
}
