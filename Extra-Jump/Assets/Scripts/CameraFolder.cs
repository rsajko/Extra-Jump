using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolder : MonoBehaviour
{
    public Transform who;
    Vector3 position;

    void Start()
    {
        transform.position = who.position;
    }


    void Update()
    {
        position = who.position;
        position.z = -10f;
        position.x = 0f;
        transform.position = Vector3.Lerp(transform.position, position, 1f * Time.deltaTime);
    }
}
