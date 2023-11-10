using System;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public event Action Finished;

    [SerializeField] private List<BaseBlock> _blocks;

    public void Init()
    {
        _blocks = new List<BaseBlock>();
        _blocks.AddRange(GetComponentsInChildren<BaseBlock>());

        foreach (var block in _blocks)
        {
            block.Init();
            block.Destroyed += Block_Destroyed;
        }
    }

    private void Block_Destroyed(BaseBlock block)
    {
        block.Destroyed -= Block_Destroyed;
        _blocks.Remove(block);

        if (_blocks.Count == 0)
        {
            Debug.LogWarning("Уровень завершен");
            Finished?.Invoke();
        }
    }
}