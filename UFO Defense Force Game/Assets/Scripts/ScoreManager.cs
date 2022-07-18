using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score; // Keep our score value
    public TextMeshProUGUI scoreText; // Visual text element to be modified


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        
    }   

    public void DecreaseScore(int amount)
    {
         score -= amount;
        UpdateScoreText();
    } 
   
    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
