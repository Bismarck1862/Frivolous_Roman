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
        
        Statics.HeroLifes = Statics.HeroLifesStart;
        Statics.AliensLifes = Statics.AliensLifesStart;
        Statics.Ammo1 = Statics.Ammo1Start;
        Statics.Ammo2 = Statics.Ammo2Start;

        //difficulty = GetComponent<Dropdown>();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void Quit()
    {
        Debug.Log("Quiting");
        Application.Quit();
    }

    void Update()
    {
        Statics.difficulty = difficulty.value;
        Debug.Log(difficulty.options[difficulty.value].text);
    }
}
