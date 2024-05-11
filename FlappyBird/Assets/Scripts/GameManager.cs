using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;
    private int score;

    public void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        highScoreText.text = "High Score :  " + PlayerPrefs.GetInt("highScore");
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        if(score> PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        highScoreText.text = "High Score :  " + PlayerPrefs.GetInt("highScore");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
