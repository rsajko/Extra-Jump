using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaatformRemove : MonoBehaviour
{

    void Update()
    {
        Transform target = GameObject.Find("Mike").transform;

        if (Vector2.Distance(target.position, transform.position) > 7)
        {
            Destroy(gameObject);
        }

    }
}
