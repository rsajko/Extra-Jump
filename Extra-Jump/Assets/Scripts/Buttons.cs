using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Buttons : MonoBehaviour
{
    public GameObject pause;
    public Sprite button_first, button_two;
    public AudioMixer am;
    public float maxValue = 20f, minValue = -80f;
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = button_two;
    }
    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = button_first;
    }
    void OnMouseUpAsButton()
    {
        switch(gameObject.name){
            case "Play":
                Time.timeScale = 1;
                SceneManager.LoadScene(1);
                break;
            case "Exit":    
              Application.Quit();
                break;
            case "Menu":
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
                break;
            case "Retry":
                SceneManager.LoadScene(1);
                Time.timeScale = 1;
                break;
            case "Back":
                SceneManager.LoadScene(0);
                break;
            case "Settings":
                SceneManager.LoadScene(3);
                break;
            case "ON":
                Time.timeScale = 1;
                am.SetFloat("masterVolume", maxValue);
                break;
            case "OFF":
                Time.timeScale = 1;
                am.SetFloat("masterVolume", minValue);
                break;
            case "Pause":
                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    pause.SetActive(true);
                }
                else
                {
                    Time.timeScale = 1;
                    pause.SetActive(false);
                }
              break;
        }

    }
}

