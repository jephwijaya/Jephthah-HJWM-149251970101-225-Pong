using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
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
        // Debug.Log("Paddle Move Tracker :" + movement);
        // Moving object using input
        rig.velocity = movement;
    }

    public void ActivatePSpeed(float magnitude, float duration)
    {
        // Debug.Log("Tes : " + speed);
        speed *= magnitude;
        StartCoroutine(SpeedTimer (magnitude, duration));
    }

    public void DeactivatePSpeed(float magnitude)
    {
        speed /= magnitude;
        // Debug.Log("Tes : " + rig.velocity);
    }

    public void ActivatePScale(float multiplier, float duration)
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*multiplier, transform.localScale.z);
        StartCoroutine(ScaleTimer (multiplier, duration));
    }

    public void DeactivatePScale(float multiplier)
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y/multiplier, transform.localScale.z);
    }

    IEnumerator SpeedTimer(float magnitude, float duration)
    {
        yield return new WaitForSeconds(duration);
        DeactivatePSpeed(magnitude);
    }

    IEnumerator ScaleTimer(float multiplier, float duration)
    {
        yield return new WaitForSeconds(duration);
        DeactivatePScale(multiplier);
    }
}
