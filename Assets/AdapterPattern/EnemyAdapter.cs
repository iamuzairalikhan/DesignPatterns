using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Adapter to make ThirdPartyEnemy compatible with IAdaptableTargetable
public class EnemyAdapter : IAdaptableTargetable
{
    private AdapterThirdPartyEnemy _adaptee; // Reference to the third-party enemy

    public EnemyAdapter(AdapterThirdPartyEnemy adaptee)
    {
        _adaptee = adaptee; // Assign the adaptee
    }

    // Adapts the GetPosition method
    public Vector3 GetPosition()
    {
        return _adaptee.Position;
    }

    // Adapts the TakeDamage method
    public void TakeDamage(int damage)
    {
        _adaptee.ReduceHealth(damage);
    }
}

