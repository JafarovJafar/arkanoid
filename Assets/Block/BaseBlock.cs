using System;
using UnityEngine;

public abstract class BaseBlock : MonoBehaviour, IDamagable
{
    public event Action<BaseBlock> Destroyed;

    public abstract void Init();

    public abstract void TakeDamage(float damage);

    protected void InvokeDestroyed() => Destroyed?.Invoke(this);
}