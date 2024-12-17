using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fish implements only the Swim interface
public class Fish_ISP : MonoBehaviour, ISwim_ISP
{
    public void Swim()
    {
        Debug.Log("Fish swims in the water!");
    }
}

