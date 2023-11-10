using UnityEngine;

public class StandartBlock : BaseBlock
{
    private float _health;

    public override void Init()
    {

    }

    public override void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"Блок {name} умер");
        gameObject.SetActive(false);
        InvokeDestroyed();
    }
}