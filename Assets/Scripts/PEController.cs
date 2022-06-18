using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball, player1, player2;
    public float multiplier, duration;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision==ball)
        {
            if(ball.GetComponent<BallController>().PlayerOne() == true)
            {
                player1.GetComponent<PlayerController>().ActivatePScale(multiplier, duration);
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                player2.GetComponent<PlayerController>().ActivatePScale(multiplier, duration);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
