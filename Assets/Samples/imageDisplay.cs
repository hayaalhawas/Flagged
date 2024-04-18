using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageDisplay : MonoBehaviour
{
 
    public Sprite failedSprite;     // Reference to "Failed" image
    public Image imageToDisplay;     // Reference to the Image UI component

    private const int score = 30;   // Constant score value

    void Start()
    {
        if (score <= 50)
        {
            imageToDisplay.sprite = failedSprite;
        }
        else
        {
            imageToDisplay.sprite = null;
        imageToDisplay.color = new Color(0f, 0f, 0f, 0f);
        }
    }
}


