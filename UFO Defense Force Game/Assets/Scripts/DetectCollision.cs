using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager
    
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreText").GetComponent<ScoreManager>(); // Reference ScoreManager Script
       
    }
    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the Score
        Destroy(gameObject); // Destroy this gameobject
        Destroy(other.gameObject); // Destroy the other gameobject it hits       
    }
    
}
