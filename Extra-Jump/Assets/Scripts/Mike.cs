using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
    public class Mike : MonoBehaviour
    {
    public float movementSpeed = 10f;
    Rigidbody2D rb;
    public float horizontal;
    private Transform death;
    bool move = true;   
    public bool refreshCamera;
    public GameObject pLost;

    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        death = GameObject.Find("Death").transform;
        }

    void FixedUpdate()
    {
        Vector2 acceliration = Input.acceleration;
       if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
            if (move == true) rb.velocity = new Vector2(acceliration.x * 10f, rb.velocity.y);
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal");
            if (move == true) rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 10f, rb.velocity.y);
        }
        
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
        SceneManager.LoadScene(2);
    }

    void Update()
        {
            Vector2 velocity = rb.velocity;
            velocity.x = 0f;
            rb.velocity = velocity;
        refreshCamera = true;

    }
    void OnCollisionExit2D(Collision2D ob)
    {
        if(ob.gameObject.tag =="Death")
        {
            Time.timeScale = 0;
            pLost.SetActive(true);          
        }
    }
    }

