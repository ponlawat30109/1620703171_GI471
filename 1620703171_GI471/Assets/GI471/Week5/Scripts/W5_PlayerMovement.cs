using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_PlayerMovement : MonoBehaviour
{

    public float speedMove;
    public float jumpPower;
    public float gravity = 20.0f;

    private float inputHorizontal;
    private float inputVertical;
    private bool inputJump;

    private CharacterController characterController;

    private Vector3 velocity;

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    void Update()
    {
        UpdateMovement();
    }

    public void SetInput_Horizontal(float axis)
    {
        inputHorizontal = axis;
    }

    public void SetInput_Vertical(float axis)
    {
        inputVertical = axis;
    }

    public void SetInput_Jump(bool toSet)
    {
        inputJump = toSet;
    }

    public void UpdateMovement()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            Vector3 dirVertical = this.transform.forward * inputVertical;
            Vector3 dirHorizontal = this.transform.right * inputHorizontal;

            velocity = (dirHorizontal + dirVertical).normalized;
            velocity *= speedMove;

            if (inputJump)
            {
                velocity.y += jumpPower;
            }
        }

        velocity.y -= gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }
}
