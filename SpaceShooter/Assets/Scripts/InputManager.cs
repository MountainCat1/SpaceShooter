using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event Action<Vector2> PlayerMovedEvent;
    
    private void Update()
    {
        var direction = GetDirection();

        if (direction.magnitude > 0)
        {
            PlayerMovedEvent?.Invoke(direction);
        }
    }

    private Vector2 GetDirection()
    {
        var direction = new Vector2(
            x: Input.GetAxis("Horizontal"),
            y: Input.GetAxis("Vertical")
        );

        return direction.normalized;
    }
}


// PlayerController <-> Unity API (Input.GetKeyDown()) // shrimple but BAD >:(
// PlayerController <-> InputManager <-> Unity API (Input.GetKeyDown()) // not shrimple but GOOD ():D 