using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.
    public bool canMove;
    public static float startTime = 2f;


    private Rigidbody2D rb2d;        //Store a reference to the Rigidbody2D component required to use 2D Physics.
    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        canMove = false;
    }
   
        // Update is called once per frame
        void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        //Store the current horizontal input in the float moveHorizontal.

        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        if (canMove && movement != Vector2.zero)
        {
            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            rb2d.AddForce(movement * speed);
        }
        startTime -= Time.deltaTime;
        if (startTime < 0)
        {
            startTime = 0;
            canMove = true;
        }
    }
    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
 
}
