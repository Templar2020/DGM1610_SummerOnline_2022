using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    private GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {   
       gameOverScreen = GameObject.Find("GameOverText");   
       gameOverScreen.gameObject.SetActive(false);
    }    

    public void GameOverText(bool isOver)
    {
        if(isOver)
        {
            
        }
        else
            gameOverScreen.gameObject.SetActive(isOver);
    }
}
