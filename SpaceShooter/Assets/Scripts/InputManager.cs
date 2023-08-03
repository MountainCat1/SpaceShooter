using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void PlayerMoved(Vector2 direction);
    public event PlayerMoved PlayerMovedEvent;
    
    public delegate void PlayerPressedE();
    public event PlayerPressedE PlayerPressedEEvent;


    private void Update()
    {
        var direction = GetDirection();

        if (direction.magnitude > 0)
        {
            PlayerMovedEvent?.Invoke(direction);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerPressedEEvent?.Invoke();
        }
    }

    private Vector2 GetDirection()
    {
        var direction = new Vector2(
            x: Input.GetAxis("Horizontal"),
            y: Input.GetAxis("Vertical")
        );

        return direction;
    }
}


// PlayerController <-> Unity API (Input.GetKeyDown()) // shrimple but BAD >:(
// PlayerController <-> InputManager <-> Unity API (Input.GetKeyDown()) // not shrimple but GOOD ():D 