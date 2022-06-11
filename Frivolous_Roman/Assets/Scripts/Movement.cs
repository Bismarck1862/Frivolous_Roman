using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravityForce = -9.81f;
    public float jumpHeight = 3f;

    public Transform ground;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(ground.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 move = transform.right * hor + transform.forward * ver;
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravityForce);
        }
        else
        {
            if(Input.GetButtonDown("Jump") && Statics.fuel > 0){
                Statics.fuel -= 1;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravityForce);
            }
        }

        if (isGrounded && Statics.fuel < Statics.fuelStartDiff)
        {
            Statics.fuel += 1;
        }
        velocity.y += gravityForce * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
