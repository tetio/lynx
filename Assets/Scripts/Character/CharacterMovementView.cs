using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementView : MonoBehaviour
{
    public Animator animator;

    private CharacterMovementModel characterMovementModel;

    void Awake()
    {
        characterMovementModel = GetComponent<CharacterMovementModel>();
    }

    // Start is called before the first frame update
    void Update()
    {
        UpdateDirection();
    }

    // Update is called once per frame
    void UpdateDirection()
    {
        Vector3 movementDirection = characterMovementModel.GetMovementDirection();
        if (characterMovementModel.isMoving())
        {
            animator.SetFloat("DirectionX", movementDirection.x);
            animator.SetFloat("DirectionY", movementDirection.y);
        }
        animator.SetBool("isMoving", characterMovementModel.isMoving());
    }
}
