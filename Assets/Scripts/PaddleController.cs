using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Vector2 speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    void Update()
    {
        MoveObject(GetInput());
    }
    
    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Paddle" +  movement);
        rig.velocity = movement;
    }

    public void ActivatePUPaddle(float speed)
    {
        rig.velocity *= speed;
    }

}
