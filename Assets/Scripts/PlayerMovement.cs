using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; 
    private Rigidbody2D rb;
    [SerializeField] 
    public float minX, maxX, minY, maxY; // Define boundaries for the scene

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = (RigidbodyConstraints2D)RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float Hmovement = horizontalInput * speed * Time.fixedDeltaTime; 

        float VerticalInput = Input.GetAxis("Vertical");
        float Vmovement = VerticalInput * speed * Time.fixedDeltaTime;

        // Calculate desired position based on movement
        Vector2 desiredPos = transform.position + new Vector3(Hmovement, Vmovement);

        
        desiredPos.x = Mathf.Clamp(desiredPos.x, minX, maxX);
        desiredPos.y = Mathf.Clamp(desiredPos.y, minY, maxY);

        transform.position = desiredPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.constraints = (RigidbodyConstraints2D)RigidbodyConstraints.FreezeRotationZ;
    }
}



