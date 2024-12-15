using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorPlayer : MonoBehaviour
{
    private IAbility _playerAbility; // The current ability of the player

    private void Start()
    {
        // Start with a basic attack
        _playerAbility = new DecoratorBasicAttack();

        // Press keys to add power-ups dynamically
        Debug.Log("Player starts with a basic attack.");
    }

    private void Update()
    {
        // Press 1 to perform the current ability
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _playerAbility.Execute();
        }

        // Press 2 to add Fire Damage
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _playerAbility = new DecoratorFireAbility(_playerAbility);
            Debug.Log("Fire ability added!");
        }

        // Press 3 to add Ice Damage
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _playerAbility = new DecoratorIceAbility(_playerAbility);
            Debug.Log("Ice ability added!");
        }

        // Press 4 to add Poison Damage
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _playerAbility = new DecoratorPoisonAbility(_playerAbility);
            Debug.Log("Poison ability added!");
        }
    }
}
