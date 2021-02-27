using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;
    public void Increment()
    {
        GameManager.heart += GameManager.love;
        PlayerPrefs.SetInt("heart", GameManager.heart);
    }
    public void buy(int num)
    {
        if (num == 1 && GameManager.heart >= 25)
        {
            GameManager.love += 1;
            GameManager.heart -= 25;
            PlayerPrefs.SetInt("heart", GameManager.heart);
            PlayerPrefs.SetInt("love", GameManager.love);
        }
        if (num == 2 && GameManager.heart >= 125)
        {
            GameManager.love += 10;
            GameManager.heart -= 125;
            PlayerPrefs.SetInt("heart", GameManager.heart);
            PlayerPrefs.SetInt("love", GameManager.love);

        }



    }
    public void Update()
    {
        ui.text = "heart: " + GameManager.heart;
    }
}