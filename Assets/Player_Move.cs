using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;

    public float moveX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove() {
        // Controls
        moveX = Input.GetAxis("Horizontal");
        Debug.Log(moveX);

        // Animations
        // Player Direction

        if (moveX < 0.0f && facingRight == false) {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true) {
            FlipPlayer();
        }

        // Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }

    void Jump(){
        // Jump code

    }

    void FlipPlayer() {

    }
}
