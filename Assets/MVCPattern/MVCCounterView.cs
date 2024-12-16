using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MVCCounterView : MonoBehaviour
{
    public TMP_Text CounterText; // UI Text element to display the counter
    public Button IncrementButton; // Button to increment the counter
    public Button DecrementButton; // Button to decrement the counter
    public Button ResetButton;     // Button to reset the counter

    // Method to update the counter display
    public void UpdateCounterDisplay(int value)
    {
        CounterText.text = "Counter: " + value;
    }
}
