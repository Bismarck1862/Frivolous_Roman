using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            CompleteLevel();
        }

    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(6);
    }
}
