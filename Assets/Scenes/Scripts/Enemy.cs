using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;

    Vector2 movement;


    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {     
        Destroy(gameObject); //Hier ga je dood
    }
}
