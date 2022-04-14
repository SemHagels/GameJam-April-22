using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float movmentspeed = 5f;
    float jumpforce = 2;
    bool jump = false;
    public Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float xMovment = Input.GetAxis("Horizontal") * movmentspeed;
        rb.velocity = new Vector2(xMovment, rb.velocity.y);
        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        if (jump == true)
        {
            rb.AddForce(new Vector2(0, jumpforce * 25));
            jump = false;
        }
    }
}
