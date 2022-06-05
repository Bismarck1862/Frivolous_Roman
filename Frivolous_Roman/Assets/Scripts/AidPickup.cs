using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidPickup : MonoBehaviour
{
    public int value = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddAidKit(value);

            Destroy(gameObject);
        }
    }
}
