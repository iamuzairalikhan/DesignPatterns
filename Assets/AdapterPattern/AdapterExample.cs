using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterExample : MonoBehaviour
{
    private void Start()
    {
        // Create a third-party enemy instance
        AdapterThirdPartyEnemy thirdPartyEnemy = new AdapterThirdPartyEnemy(new Vector3(10, 0, 5), 100);

        // Use the adapter to make the third-party enemy compatible
        IAdaptableTargetable targetableEnemy = new EnemyAdapter(thirdPartyEnemy);

        // Create and use the targeting system
        AdapterTargetingSystem targetingSystem = new AdapterTargetingSystem();
        targetingSystem.AttackTarget(targetableEnemy);
    }
}
