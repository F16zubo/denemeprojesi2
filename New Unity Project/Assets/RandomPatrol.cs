using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public GameObject target;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (target.activeInHierarchy)
            {
                target.SetActive(false);
            }
            else
            {
                target.SetActive(true);
            }

        }
        
    }
}

