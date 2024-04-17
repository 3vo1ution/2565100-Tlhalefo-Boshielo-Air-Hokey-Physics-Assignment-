using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public Rigidbody2D PuckRB;
public class Puck : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
         PuckRB = GetComponent<Rigidbody2D>();
    }
}
