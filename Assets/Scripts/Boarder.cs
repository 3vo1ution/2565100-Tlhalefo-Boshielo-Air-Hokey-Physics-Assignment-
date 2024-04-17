using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Transform objectToReset; // Reference to the object whose position needs to be reset
    public float resetCoordinate = 0f; // The coordinate at which to reset the position

    private bool hasCrossedCoordinate = false;

    void Update()
    {
        // Check if the object has crossed the resetCoordinate
        if (transform.position.x > resetCoordinate)
        {
            hasCrossedCoordinate = true;
        }
        else
        {
            // If it crossed before and now it's back, reset the flag
            if (hasCrossedCoordinate)
            {
                hasCrossedCoordinate = false;
            }
        }

        // If the object has crossed the resetCoordinate, reset the position of objectToReset
        if (hasCrossedCoordinate)
        {
            ResetObjectPosition();
        }
    }

    void ResetObjectPosition()
    {
        // Reset the position of the objectToReset to its initial position
        objectToReset.position = objectToReset.position;
        // Additionally, you may want to reset any velocity or other state variables of the object
        Rigidbody2D rb = objectToReset.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }
    }
}
