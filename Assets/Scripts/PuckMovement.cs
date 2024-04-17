using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D PuckRB;
    public string targetTag = "paddle"; 

    void Start()
    {
        PuckRB = GetComponent<Rigidbody2D>();
        // Add an initial force to get the puck moving
        PuckRB.velocity = transform.right * speed;

    }

    void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.collider.CompareTag("paddle"))
        {
            // Get the normal of the collision
            Vector2 normal = collision.contacts[0].normal;
            // Reflect the puck's velocity off the collision normal
            Vector2 reflection = Vector2.Reflect(PuckRB.velocity, normal);
            PuckRB.velocity = reflection.normalized * speed;
        }
    }
}
