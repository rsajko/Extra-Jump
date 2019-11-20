using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(Rigidbody2D))]
    public class Mike : MonoBehaviour
    {
    public float movementSpeed = 10f;
    Rigidbody2D rb;
    float horizontal;
    private Transform death;

    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        death = GameObject.Find("Death").transform;
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
        if (transform.position.x <-6f)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }
        else if(transform.position.x>6f)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }
    }
    void GameOver()
    {
        print("Game END");
    }

    void Update()
        {
            Vector2 velocity = rb.velocity;
            velocity.x = 0f;
            rb.velocity = velocity;
        }
    void DeathMike()
    {
        if(death.position.y<transform.position.y-5)
        {
            death.position = new Vector2(0, transform.position.y - 5);
        }
        if(death.position.y >transform.position.y)
        {
            GameOver();
        }
    }
    }

