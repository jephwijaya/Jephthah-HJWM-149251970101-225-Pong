using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreHome, scoreAway;
    public ScoreManager manager;
    
    private void Update()
    {
        scoreHome.text = manager.homeScore.ToString();
        scoreAway.text = manager.awayScore.ToString();
    }
}
