using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Sprite button_first, button_two;
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = button_two;
    }
    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = button_first;
    }
    void MouseUpAsButton()
    {
        switch(gameObject.name){
            case "Play":
                SceneManager.LoadScene(1);
                break;
            case "Exit":
                Application.Quit();
                break;
        }
    }
}

