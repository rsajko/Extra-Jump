using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class score_script : MonoBehaviour
{

    public float score;
    private Transform target;
    public Text txt;

    void Start()
    {
        target = GameObject.Find("Mike").transform;
    }
    void Update()
    {
        EnterScore();
    }

    void EnterScore()
    {

        if (target.position.y > score)
        {
            score = target.position.y;
        }
        int score1 = (int)score;
        txt.text = score1.ToString();
    }
}
