using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class handles only the player's health logic.
// Related to "Single Responsibility" principle of SOLID.
public class PlayerHealth_SingleResponsibility : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth; // Initialize health
    }

    // Handles damage to the player
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); // Ensure health doesn't go below zero
        Debug.Log($"Player Health: {currentHealth}");

        if (currentHealth == 0)
        {
            Die();
        }
    }

    // Handles healing the player
    public void Heal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth); // Ensure health doesn't exceed max
        Debug.Log($"Player Health: {currentHealth}");
    }

    // Manages player death
    private void Die()
    {
        Debug.Log("Player has died!");
        // Additional death logic like triggering animations or restarting the level
    }
}

