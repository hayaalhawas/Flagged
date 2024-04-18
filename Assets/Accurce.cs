using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accurce : MonoBehaviour
{

     public Slider correctSlider; // Reference to the correct answer slider
    public Slider incorrectSlider; // Reference to the incorrect answer slider

    const int totalQuestions = 12;
    const int correctAnswers = 2;
    const int incorrectAnswers = totalQuestions - correctAnswers; // Calculate incorrect answers

    float correctPercentage;
    float incorrectPercentage;

    void Start()
    {
        // Calculate percentages in Start for clarity
        correctPercentage = (float)correctAnswers / totalQuestions * 100f;
        incorrectPercentage = (float)incorrectAnswers / totalQuestions * 100f;

        // Set slider values based on percentages
        correctSlider.value = correctPercentage / 100f;
        incorrectSlider.value = incorrectPercentage / 100f;
    }
}

