using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    // AI movement speed
    [SerializeField]
    public float speed = 5f; 
    public Rigidbody2D puck; 
    private Rigidbody2D AIpaddle;
    public Transform Puck;
    [SerializeField]
    public float minX, maxX, minY, maxY;

    void Start()
    {
        AIpaddle = GetComponent<Rigidbody2D>();
        // Get the Transform (i.e the coordinates of) component of the puck
        Puck = puck.transform;
       
    }

    void FixedUpdate()
    {
        Vector2 puckPosition = Puck.position; // Get the Puck's position

        
        Vector2 desiredPos = transform.position;

        desiredPos.x = Mathf.Clamp(desiredPos.x, minX, maxX);
        desiredPos.y = Mathf.Clamp(desiredPos.y, minY, maxY);

       // transform.position = desiredPos;

        // direction vector from AI to Puck
        Vector2 direction = (puckPosition - AIpaddle.position).normalized;

        // Move the AI towards the Puck with the set speed
        AIpaddle.MovePosition(AIpaddle.position + direction * speed * Time.fixedDeltaTime);
    }
}
