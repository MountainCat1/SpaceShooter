using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float health;
    [field: SerializeField] public float Speed { get; set; }

    [SerializeField] private Rigidbody2D body;
    
    public void Move(Vector2 direction)
    {
        var position = (Vector2)transform.position;

        position += direction.normalized * (Speed * Time.fixedDeltaTime);
        
        body.MovePosition(position);
    }

    public void Attack()
    {
        
    }
}