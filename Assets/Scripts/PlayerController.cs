using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {     
        if (Input.GetKey(upKey))
        {
            //Move Up
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            //Move Down
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {   
        //Log Paddle Player Movement
        Debug.Log("Paddle Move Tracker :" + movement);
        //Moving object using input
        rig.velocity = movement;
    }
}
