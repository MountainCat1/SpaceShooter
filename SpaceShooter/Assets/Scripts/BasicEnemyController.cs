using UnityEngine;

public class BasicEnemyController : EnemyController
{
    private void FixedUpdate()
    {
        enemy.Move(new Vector2(0, -1));
    }
}
