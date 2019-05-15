using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;

    private Rigidbody2D rigidBody;

    private float moveX;
    private float moveY;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

        if (Input.GetButtonDown("Jump")) {
            PlayerJump();
        }
       
    }

    void PlayerMove() {
        // Controls
        moveX = Input.GetAxis("Horizontal");
 
        // Animations
        // Player Direction

        // move left
        if (moveX < 0.0f && facingRight == false) {
            FlipPlayer();
        }
        // move right
        else if (moveX > 0.0f && facingRight == true) {
            FlipPlayer();
        }

        // Physics
        rigidBody.velocity = new Vector2(moveX * playerSpeed, rigidBody.velocity.y);

    }

    void PlayerJump(){
        // Jump code

        rigidBody.AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer() {
        facingRight = !facingRight;

        // change the scale of player to a negative
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
