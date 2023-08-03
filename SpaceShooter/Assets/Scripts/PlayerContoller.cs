using System;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed = 0.001f;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        inputManager.PlayerMovedEvent += OnMovementEvent;
        inputManager.PlayerPressedEEvent += InputManagerOnPlayerPressedEEvent;
    }

    private void InputManagerOnPlayerPressedEEvent()
    {
        Debug.Log("The grandmother has returned!");
    }

    private void OnMovementEvent(Vector2 direction)
    {
        Move(direction);
    }
    
    private void Move(Vector2 direction)
    {
        if (direction != direction.normalized)
        {
            Debug.LogWarning("Move called with unnormalized direction");
            // direction = direction.normalized;
        }

        var position = (Vector2)_transform.position;

        position += direction * (speed * Time.deltaTime);

        _transform.position = position;
    }
}


// [SerializeField] private InputManager inputManager;
//
// private void Start()
// {
//     inputManager.UserMovedEvent += InputManagerOnUserMovedEvent;
// }
//
// private void InputManagerOnUserMovedEvent(Vector2 direction)
// {
//     throw new NotImplementedException();
// }