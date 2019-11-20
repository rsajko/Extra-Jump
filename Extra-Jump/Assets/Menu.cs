using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Sprite button_first, button_two;

 public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = button_two;
    }
  public  void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = button_first;
    }
}
