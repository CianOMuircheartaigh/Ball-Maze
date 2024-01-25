using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{ 
    Rigidbody2D rb;
    Vector2 lastVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        
    }

  
    void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector2.Reflect(lastVelocity.normalized,
                                        collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 2f);
    }


}
