using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInteractable : Interactable
{
    public GameObject mainPanel;
    public Image image;
    Sprite sprite;
    bool isOn;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }
    public override void Interact()
    {
        if(!isOn)
        {
            image.sprite = sprite;
            mainPanel.SetActive(true);    
            isOn = true;
        }
        else if(isOn)
        {
            mainPanel.SetActive(false);
            isOn = false;
        }
    }
}
