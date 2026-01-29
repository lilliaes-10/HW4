using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void OnEnable()
    {
        PlayerController.OnPlayerDeath += StopGame;
    }

    void OnDisable()
    {
        PlayerController.OnPlayerDeath -= StopGame;
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }
    
}
