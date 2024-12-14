using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static instance variable to hold the single instance of GameManager.
    public static GameManager Instance { get; private set; }

    // Example variable to demonstrate the singleton's functionality.
    public int score;

    // Awake is called before Start. It's used here to set up the Singleton.
    private void Awake()
    {
        // Check if an instance of GameManager already exists.
        if (Instance != null && Instance != this)
        {
            // Destroy this instance if another already exists.
            Debug.LogWarning("Multiple GameManager instances detected. Destroying duplicate.");
            Destroy(gameObject);
            return;
        }

        // Assign this instance to the static variable.
        Instance = this;

        // Make this object persistent across scenes.
        DontDestroyOnLoad(gameObject);
    }

    // Method to increase the score.
    public void IncreaseScore(int value)
    {
        score += value;
        Debug.Log($"Score increased! Current score: {score}");
    }
}
