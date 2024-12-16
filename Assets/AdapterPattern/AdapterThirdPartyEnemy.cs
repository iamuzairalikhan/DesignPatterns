using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// A third-party enemy class (does not implement IAdapterTargetable)
public class AdapterThirdPartyEnemy
{
    public Vector3 Position; // Enemy's position
    public int Health; // Enemy's health

    public AdapterThirdPartyEnemy(Vector3 position, int health)
    {
        Position = position;
        Health = health;
    }

    // Reduces the enemy's health
    public void ReduceHealth(int damage)
    {
        Health -= damage;
        Debug.Log($"Third-Party Enemy took {damage} damage, remaining health: {Health}");
    }
}





