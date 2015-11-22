using UnityEngine;
using System.Collections;

public class GameManager : Manager<GameManager>
{
    int level = PlayerPrefs.GetInt("Level");

    public void Awake()
    {
        if (PlayerPrefs.GetInt("Level")==0)
        {
            PlayerPrefs.SetInt("Level",1);
        }
    }
}



