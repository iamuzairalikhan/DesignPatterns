using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Concrete implementation of IWeapon_DIP for Gun
public class GunWeapon_DIP : MonoBehaviour, IWeapon_DIP
{
    public void Attack()
    {
        Debug.Log("Shooting with a Gun!");
    }
}

