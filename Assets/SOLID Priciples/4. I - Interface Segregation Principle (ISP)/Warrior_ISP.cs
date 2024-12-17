using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Warrior implements Attack and Jump interfaces
public class Warrior_ISP : MonoBehaviour, IAttack_ISP, IJump_ISP
{
    public void Attack()
    {
        Debug.Log("Warrior attacks with a sword!");
    }

    public void Jump()
    {
        Debug.Log("Warrior jumps over the obstacle!");
    }
}

