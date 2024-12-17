using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Concrete implementation of IWeapon_DIP for Sword
public class SwordWeapon_DIP : MonoBehaviour, IWeapon_DIP
{
    public void Attack()
    {
        Debug.Log("Attacking with a Sword!");
    }
}

