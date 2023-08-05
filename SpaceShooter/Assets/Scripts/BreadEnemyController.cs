
using UnityEngine;

public class BreadEnemyController : EnemyController
{
    [SerializeField] private float turnSpeed = 1f;
    [SerializeField] private float acceleration = 1f;
    
    private Vector2 _direction = new Vector2(0, -1);
    private void FixedUpdate()
    {
        enemy.Speed += acceleration * Time.fixedDeltaTime;
        
        _direction.x += turnSpeed * Time.fixedDeltaTime;
        enemy.Move(_direction);

    }
}