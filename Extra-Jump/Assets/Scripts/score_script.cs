using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class score_script : MonoBehaviour
{

    public float score;
    private Transform target;
    public Text txt;
    int score1;
    public Text currentScore;

    void Start()
    {
        target = GameObject.Find("Mike").transform;
        currentScore.text = "Your score: " + score1;
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
      //  PlayerPrefs.SetInt("ScoreGameOverTXT", score1);
    }

}
