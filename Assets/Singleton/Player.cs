using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void CheckInstanceCallonClick()
    {
        // Access the Singleton instance to increase the score.
        GameManager.Instance.IncreaseScore(10);
    }
}

