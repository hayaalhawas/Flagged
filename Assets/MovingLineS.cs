using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLineS : MonoBehaviour
{
    public float minX = -108.7f;
    public float maxX = 108.5f;
    public float constantScore = 65.0f;

    void Start()
    {
        // Calculate the percentage of the constant score between 0 and 100
        float percentage = constantScore / 100.0f;

        // Calculate the new X position based on the percentage
        float newX = Mathf.Lerp(minX, maxX, percentage);

        // Update the X position of the MovingLine image
        RectTransform movingLineTransform = GetComponent<RectTransform>();
        movingLineTransform.anchoredPosition = new Vector2(newX, movingLineTransform.anchoredPosition.y);
    }
}