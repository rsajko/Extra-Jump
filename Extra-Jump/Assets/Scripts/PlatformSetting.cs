using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSetting : MonoBehaviour
{
    [HideInInspector] public Transform target;

    void Start()
    {

        target = GameObject.Find("Mike").transform;

    }


    void Update()
    {

        if (gameObject.GetComponent<Collider2D>())
        {

            if (target.position.y < gameObject.transform.position.y + 0.2f)
            {

                gameObject.GetComponent<BoxCollider2D>().enabled = false;

            }
            else
            {

                gameObject.GetComponent<BoxCollider2D>().enabled = true;

            }

        }

    }

}