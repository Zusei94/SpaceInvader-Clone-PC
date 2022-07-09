using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy(gameObject) : destroy the game object that holds this script

        if (collision.gameObject.tag != "Player")
        {
            // destroy the game object that collide with the game object that holds this script
            Destroy(collision.gameObject);
        }
    }
}
