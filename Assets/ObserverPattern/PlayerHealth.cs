using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

// Subject: Player Health
public class PlayerHealth : MonoBehaviour
{
    // Event to notify observers when health changes
    public event Action<int> OnHealthChanged;

    private int _health = 100; // Player's initial health

    public int Health
    {
        get => _health;
        private set
        {
            _health = value;

            // Notify all observers about the health change
            OnHealthChanged?.Invoke(_health);
        }
    }

    // Method to reduce health
    public void TakeDamage(int damage)
    {
        Health = Mathf.Max(0, _health - damage); // Prevent health from going below 0
        Debug.Log($"Player took {damage} damage. Current health: {_health}");
    }

    // Method to heal the player
    public void Heal(int amount)
    {
        Health = Mathf.Min(100, _health + amount); // Cap health at 100
        Debug.Log($"Player healed by {amount}. Current health: {_health}");
    }
}


