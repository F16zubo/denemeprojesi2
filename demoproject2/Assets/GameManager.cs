using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int heart;
    public static int love;
    void Start()
    {
        love = PlayerPrefs.GetInt("love", 1);
        heart = PlayerPrefs.GetInt("heart", 0);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            PlayerPrefs.DeleteAll();
        }
    }
}