using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball, player1, player2;
    public float magnitude, duration;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision==ball)
        {
            if(ball.GetComponent<BallController>().PlayerOne() == true)
            {
                player1.GetComponent<PlayerController>().ActivatePSpeed(magnitude, duration);
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                player2.GetComponent<PlayerController>().ActivatePSpeed(magnitude, duration);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
