using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Robot implements only the Attack interface
public class Robot_ISP : MonoBehaviour, IAttack_ISP
{
    public void Attack()
    {
        Debug.Log("Robot shoots lasers!");
    }
}

