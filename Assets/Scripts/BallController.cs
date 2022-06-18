using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed, resetPosition;

    private Rigidbody2D rig;

    private bool isPlayer1;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void DeactivatePUSpeedUp(float magnitude)
    {
        rig.velocity /= magnitude;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player 1")
        {
            isPlayer1 = true;
        }
        else if (collision.gameObject.name == "Player 2")
        {
            isPlayer1 = false;
        }
    }

    public bool PlayerOne()
    {
        return isPlayer1;
    }
}
