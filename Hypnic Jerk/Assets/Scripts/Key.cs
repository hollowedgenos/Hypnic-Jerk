using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    [SerializeField] private Rigidbody2D key;
    [SerializeField] private Movement playerMove;
    public bool upArrowPressed;

    // Start is called before the first frame update
    void Start()
    {
        key = gameObject.GetComponent<Rigidbody2D>();
        upArrowPressed = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upArrowPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            upArrowPressed = false;
        }
    }

    // Kick Method adds force to the box (key) when called
    public void Kick()
    {
        Movement playerMovement = playerMove.GetComponent<Movement>();

        // Kicks either left or right depending on where player is facing.
        if (playerMovement.isFacingRight && (upArrowPressed == false))
        {
            key.AddForce(new Vector2(50, 0), ForceMode2D.Impulse);    
        }
        else if ((upArrowPressed == true) && (playerMovement.isFacingRight || !playerMovement.isFacingRight))
        {
            key.AddForce(new Vector2(0, 30), ForceMode2D.Impulse);
        }
        else
        {
            key.AddForce(new Vector2(-50, 0), ForceMode2D.Impulse);
        }

    }

}
