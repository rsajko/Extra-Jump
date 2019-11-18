using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(Rigidbody2D))]
    public class Mike : MonoBehaviour
    {
    public float movementSpeed = 10f;
    Rigidbody2D rb;
    float horizontal;

    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal");
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 10f, rb.velocity.y);
    }

    void Update()
        {
            Vector2 velocity = rb.velocity;
            velocity.x = 0f;
            rb.velocity = velocity;
        }
    }

