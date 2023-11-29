using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerGameController : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;
    public float jumpForce = 8.0f; 


    private CharacterController characterController;
    private Camera playerCamera;

    private float verticalRotation = 0f;

    private bool isPlayerMoving = false;
    private bool isJumping = false; 

    private bool IsPlayerMoving
    {
        get => isPlayerMoving;

        set
        {
            if (isPlayerMoving != value)
            {
                if (value == true)
                {
                    isPlayerMoving = true;
                    StartCoroutine(WalkSound());
                }
                else
                {
                    isPlayerMoving = false;
                }
            }
        }
    }

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();

        // Lock cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (!GameConstraints.Instance.IsGamePaused)
        {
            // Player movement
            float forwardBackward = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
            float leftRight = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

            Vector3 movement = transform.forward * forwardBackward + transform.right * leftRight;

            // Check for jump input
            if (characterController.isGrounded)
            {
                isJumping = false;

                if (Input.GetButtonDown("Jump"))
                {
                    isJumping = true;
                }
            }

            // Apply jump force
            if (isJumping)
            {
                movement.y = jumpForce;
                isJumping = false;
            }

            IsPlayerMoving = movement.magnitude != 0 ? true : false;

            characterController.Move(movement);

            // Player rotation (looking around)
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            verticalRotation -= mouseY;
            verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

            playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);
        }
        else
        {
            IsPlayerMoving = false;
        }
    }

    IEnumerator WalkSound()
    {
        while (IsPlayerMoving)
        {
            SoundManager.Instance.CreateAudioSource(SoundManager.Instance.WalkSound);
            yield return new WaitForSeconds(0.5f);
        }
    }
}


