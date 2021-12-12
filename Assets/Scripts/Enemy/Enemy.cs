using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyDamage(damage);
        }

        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
