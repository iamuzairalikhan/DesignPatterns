using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Damage Test: Simulate taking damage or healing
public class DamageTest : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private UIManager uIManager;

    private void Start()
    {
        uIManager = FindAnyObjectByType<UIManager>();
        uIManager.UpdateHealthUI(0);
    }

    private void Update()
    {
        // Press D to take damage
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerHealth.TakeDamage(10);
            uIManager.UpdateHealthUI(playerHealth.Health);
        }

        // Press H to heal
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerHealth.Heal(15);
            uIManager.UpdateHealthUI(playerHealth.Health);
        }
    }

    public void IncreaseHealth()
    {
        playerHealth.Heal(15);
    }

    public void DecreaseHealth()
    {
        playerHealth.TakeDamage(10);
    }
}

