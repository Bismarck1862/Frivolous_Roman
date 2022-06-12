using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentAidKit;
    public int currentAmmo;
    public int currentAmmo2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddAidKit(int toAdd)
    {
        currentAidKit += toAdd;
    }

    public void AddAmmo(int toAdd)
    {
        currentAmmo += toAdd;
    }

    public void AddAmmo2(int toAdd)
    {
        currentAmmo2 += toAdd;
    }
}
