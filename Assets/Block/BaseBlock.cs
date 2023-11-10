using UnityEngine;

public abstract class BaseBlock : MonoBehaviour, IDamagable
{
    public abstract void TakeDamage(float damage);
}
