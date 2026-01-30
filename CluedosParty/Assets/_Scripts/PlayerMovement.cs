using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Estadísticas")]
    [SerializeField, Range(3, 10)] private float _speed;
    [SerializeField, Range(3, 10)] private float _jumpSpeed;
    private float verticalInput;
    private float horizontalInput;
    private float verticalVelocity;
    private CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;
        movement *= _speed;
        movement.y = verticalVelocity;


        if (cc.isGrounded)
        {
            verticalVelocity = -1f; //Para que se mantenga en el suelo

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity= _jumpSpeed;
            }
        }
        else
        {
            verticalVelocity -= 9.81f * Time.deltaTime;
        }

        cc.Move(movement*Time.deltaTime);
    }


}
