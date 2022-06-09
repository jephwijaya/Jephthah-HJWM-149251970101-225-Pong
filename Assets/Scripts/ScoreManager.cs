using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int homeScore, awayScore, gameScore;
    public BallController ball;

    public void AddHomeScore(int increment)
    {
        homeScore += increment;
        ball.ResetBall();

        if(homeScore>=gameScore)
        {
            GameOver();
        }
    }

    public void AddAwayScore(int increment)
    {
        awayScore += increment;
        ball.ResetBall();

        if(awayScore>=gameScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
