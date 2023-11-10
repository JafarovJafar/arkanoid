using UnityEngine;

[CreateAssetMenu(menuName = "BlockData")]
public class BlockData : ScriptableObject
{
    [field: SerializeField] public Sprite Sprite { get; private set; }
    [field: SerializeField] public int Health { get; private set; }
}