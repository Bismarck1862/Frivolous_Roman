using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class GoToLevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.DelayedCall(4, GoToNextScene);
    }

    // Update is called once per frame
    void GoToNextScene()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Statics.fuel = Statics.fuelStartDiff;
        Statics.Ammo1 = Statics.Ammo1StartDiff;
        Statics.Ammo2 = Statics.Ammo2StartDiff;
        Statics.AliensLifes = Statics.AliensLifesStartDiff;
        Statics.HeroLifes = Statics.HeroLifesStartDiff;
        SceneManager.LoadScene(4);
    }
}
