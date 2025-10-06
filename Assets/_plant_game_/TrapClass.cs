using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TrapClass : DamagableObject
{
    public void ApplyDamage(DamagableObject damagable, int damage)
    {
        damagable.TakeDamage(damage);
    }

}
