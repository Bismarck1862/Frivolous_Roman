using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD_Controller : MonoBehaviour
{
    public TMP_Text ammo;

    void Update()
    {
        ammo.text = Statics.Ammo1.ToString();
    }
}
