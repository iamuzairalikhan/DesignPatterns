using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Observer: UI Manager
public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private TMP_Text healthText;

    private void OnEnable()
    {
        // Subscribe to the PlayerHealth's OnHealthChanged event
        playerHealth.OnHealthChanged += UpdateHealthUI;
    }

    private void OnDisable()
    {
        // Unsubscribe from the event to avoid memory leaks
        playerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    // Method to update the health UI
    public void UpdateHealthUI(int currentHealth)
    {
        Debug.Log($"Health UI updated: {currentHealth}");
        healthText.text = currentHealth.ToString();
        // Here, you'd update the actual UI element (e.g., health bar).
    }
}
