using UnityEngine;

public class Playercollison : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
             movement.enabled = false;
            FindObjectOfType<GameManager>().gameover();
        }

        if (collisionInfo.collider.tag == "sylinder")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().gameover();
        }
    }
}
