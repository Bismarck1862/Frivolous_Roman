using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public TMP_Dropdown difficulty;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SetDifficulty(difficulty.value);
        Statics.IsGameActive = true;
        Time.timeScale = 1f;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("Quiting");
        Application.Quit();
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
        if(level == 1)
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
        if(level == 2)
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

    void Update()
    {
        Statics.difficulty = difficulty.value;
        SetDifficulty(difficulty.value);
    }
}
