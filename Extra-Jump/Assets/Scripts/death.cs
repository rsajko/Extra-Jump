using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    private Vector3 pos_offset;
    // Start is called before the first frame update
    void Start()
    {
        pos_offset = Camera.main.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.transform.position - pos_offset;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Mike")
        {
           // SceneManager.LoadScene(2);
        }

    }
}
