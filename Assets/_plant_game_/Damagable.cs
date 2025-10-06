using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamagableObject
{
    public int Hp { get; set; }
    public int MaxHp { get; set; }
    

    public void TakeDamage(int damage)
    {
        Hp = -damage;
        if (Hp < 1)
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {
        Debug.Log("object destroyed");
    }

}