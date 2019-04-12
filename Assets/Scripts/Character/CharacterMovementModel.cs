using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementModel : MonoBehaviour
{
    public float speed;

    private Vector3 movementDirection;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() => UpdateMovement();

    void UpdateMovement()
    {
        if (movementDirection != Vector3.zero)
        {
            movementDirection.Normalize();
        }
        body.velocity = movementDirection * speed;
    }

    public void SetDirection(Vector2 direction)
    {
        movementDirection = new Vector3(direction.x, direction.y, 0);
    }

    public bool isMoving()
    {
        return (movementDirection != Vector3.zero);
    }

    public Vector3 GetMovementDirection()
    {
        return movementDirection;
    }
}
