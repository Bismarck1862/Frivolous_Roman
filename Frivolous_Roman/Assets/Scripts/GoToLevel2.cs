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
        SceneManager.LoadScene(4);
    }
}
