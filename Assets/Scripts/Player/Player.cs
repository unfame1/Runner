using System;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int health;

    public event UnityAction<int> HealthChanged;

    private void Start()
    {
        HealthChanged?.Invoke(health);
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
        HealthChanged?.Invoke(health);
        
        if (health <= 0)
            Die();
    }

    private void Die()
    {
        
    }
}
