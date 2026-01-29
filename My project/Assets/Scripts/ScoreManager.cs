using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TMP_Text scoreText;
    public AudioSource scoreSound;

    private int score = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void OnEnable()
    {
        PlayerController.OnPipePassed += AddScore;
    }

    void OnDisable()
    {
        PlayerController.OnPipePassed -= AddScore;
    }

    void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        scoreSound.Play();
    }
}
