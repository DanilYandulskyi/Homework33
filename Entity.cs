using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private Health _health;
    
    public Health Health => _health;
    protected int Damage => _damage;
}
