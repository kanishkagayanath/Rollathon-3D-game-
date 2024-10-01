using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a forward force


        if (Input.GetKey("d")) //if the player is pressing the "d" key
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange); //add a force to the right
        }

        if (Input.GetKey("a")) //if the player is pressing the "a" key
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //add a force to the left
        }

        if (rb.position.y < -1f) //if the player falls off the map
        {
            FindObjectOfType<GameManager>().gameover(); //call the gameover function from the GameManager script
        }
    }
}
