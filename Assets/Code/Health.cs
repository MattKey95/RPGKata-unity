using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : IHealth
{
    public int CurrentHealth { get ; set; }
    public bool IsDead { get; set; }

    public int Level;

    public Health()
    {
        CurrentHealth = 1000;
        IsDead = false;
    }

    public void Heal(int amount)
    {
        if(!IsDead)
            CurrentHealth += amount;

        if (CurrentHealth > 1000)
            CurrentHealth = 1000;
    }

    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0)
            IsDead = true;
    }
}
