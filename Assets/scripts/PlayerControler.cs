using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    float maxSpeed = 8.0f;
    bool isOnGround = false;

    // Create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 30.0f;
        }
        else
        {
            maxSpeed = 8.0f;
        }
        //Create a 'float' that will be equal to the player horizonal input
        float movementValueX = 1.0f;

        //Change the X velocity of the Rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX, playerObject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 500.0f));
        }
    }
    
}


