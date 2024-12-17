using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_ISP : MonoBehaviour
{
    void Start()
    {
        // Create GameObjects and assign behaviors
        GameObject warrior = new GameObject("Warrior");
        warrior.AddComponent<Warrior_ISP>();

        GameObject fish = new GameObject("Fish");
        fish.AddComponent<Fish_ISP>();

        GameObject robot = new GameObject("Robot");
        robot.AddComponent<Robot_ISP>();

        // Test behaviors
        Debug.Log("Testing Warrior:");
        IAttack_ISP warriorAttack = warrior.GetComponent<IAttack_ISP>();
        IJump_ISP warriorJump = warrior.GetComponent<IJump_ISP>();
        warriorAttack?.Attack();
        warriorJump?.Jump();

        Debug.Log("Testing Fish:");
        ISwim_ISP fishSwim = fish.GetComponent<ISwim_ISP>();
        fishSwim?.Swim();

        Debug.Log("Testing Robot:");
        IAttack_ISP robotAttack = robot.GetComponent<IAttack_ISP>();
        robotAttack?.Attack();
    }
}

