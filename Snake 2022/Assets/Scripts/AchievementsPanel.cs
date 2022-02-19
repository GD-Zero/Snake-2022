using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsPanel : MonoBehaviour
{
    public int highscore;
    public GameObject A1, A2, A3, NA1, NA2, NA3;

    void Update()
    {
        highscore = PlayerPrefs.GetInt("MainScore");
        if (highscore >= 1)
        {
            A1.SetActive(false);
            NA1.SetActive(true);
        }
        if (highscore >= 100)
        {
            A2.SetActive(false);
            NA2.SetActive(true);
        }
        if (highscore >= 1000)
        {
            A3.SetActive(false);
            NA3.SetActive(true);
        }
    }
}
