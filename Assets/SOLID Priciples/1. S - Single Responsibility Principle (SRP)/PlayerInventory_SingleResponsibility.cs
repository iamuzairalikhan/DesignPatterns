using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class handles only the player's inventory logic.
// Related to "Single Responsibility" principle of SOLID.
public class PlayerInventory_SingleResponsibility : MonoBehaviour
{
    private List<string> inventory = new List<string>();

    // Adds an item to the player's inventory
    public void AddItem(string itemName)
    {
        inventory.Add(itemName);
        Debug.Log($"{itemName} added to inventory.");
    }

    // Removes an item from the player's inventory
    public void RemoveItem(string itemName)
    {
        if (inventory.Contains(itemName))
        {
            inventory.Remove(itemName);
            Debug.Log($"{itemName} removed from inventory.");
        }
        else
        {
            Debug.Log($"{itemName} not found in inventory.");
        }
    }

    // Displays the current inventory
    public void ShowInventory()
    {
        Debug.Log("Inventory: " + string.Join(", ", inventory));
    }
}
