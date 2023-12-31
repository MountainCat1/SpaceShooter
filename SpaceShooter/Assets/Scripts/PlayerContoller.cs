﻿using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed = 5f;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        inputManager.PlayerMovedEvent += OnPlayerMoved;
    }

    private void OnPlayerMoved(Vector2 direction)
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