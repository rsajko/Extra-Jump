using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform : MonoBehaviour
{
    private Transform target;
   // public float position = 0;
    public float jumpForce = 10f;
     void Update()
    {
        Transform target = GameObject.Find("Mike").transform;
        if (
         target.position.y > transform.position.y+13)
        {
            Destroy(gameObject);
        }
 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }

}
