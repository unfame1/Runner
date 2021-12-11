using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int health;

    public void ApplyDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
            Die();
    }

    private void Die()
    {
        
    }
}
