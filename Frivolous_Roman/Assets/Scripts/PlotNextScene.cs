using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlotNextScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        SetDifficulty(Statics.difficulty);
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

        public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToGame()
    {
        SceneManager.LoadScene("FirstPlot");
    }

    private void SetDifficulty(int level)
    {
        if (level == 0)
        {
            Statics.HeroLifes = Statics.HeroLifesStart * 2;
            Statics.AliensLifes = Statics.AliensLifesStart / 2;
            Statics.Ammo1 = Statics.Ammo1Start * 2;
            Statics.Ammo2 = Statics.Ammo2Start * 2;
            Statics.fuel = Statics.fuelStart * 2;

            Statics.fuelStartDiff = Statics.fuel;
            Statics.Ammo1StartDiff = Statics.Ammo1;
            Statics.Ammo2StartDiff = Statics.Ammo2;
            Statics.AliensLifesStartDiff = Statics.AliensLifes;
            Statics.HeroLifesStartDiff = Statics.HeroLifes;
        }
        if (level == 1)
        {
            Statics.HeroLifes = Statics.HeroLifesStart;
            Statics.AliensLifes = Statics.AliensLifesStart;
            Statics.Ammo1 = Statics.Ammo1Start;
            Statics.Ammo2 = Statics.Ammo2Start;
            Statics.fuel = Statics.fuelStart;

            Statics.fuelStartDiff = Statics.fuel;
            Statics.Ammo1StartDiff = Statics.Ammo1;
            Statics.Ammo2StartDiff = Statics.Ammo2;
            Statics.AliensLifesStartDiff = Statics.AliensLifes;
            Statics.HeroLifesStartDiff = Statics.HeroLifes;
        }
        if (level == 2)
        {
            Statics.HeroLifes = Statics.HeroLifesStart / 2;
            Statics.AliensLifes = Statics.AliensLifesStart * 2;
            Statics.Ammo1 = Statics.Ammo1Start / 2;
            Statics.Ammo2 = Statics.Ammo2Start / 2;
            Statics.fuel = Statics.fuelStart / 2;

            Statics.fuelStartDiff = Statics.fuel;
            Statics.Ammo1StartDiff = Statics.Ammo1;
            Statics.Ammo2StartDiff = Statics.Ammo2;
            Statics.AliensLifesStartDiff = Statics.AliensLifes;
            Statics.HeroLifesStartDiff = Statics.HeroLifes;
        }
    }

}
