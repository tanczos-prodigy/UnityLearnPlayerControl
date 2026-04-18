using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{
    public float rotationSpeed;
    public Slider mySlider;
    public float verticalSpeed = 25f;
    public float maxPitchAngle = 30f;

    private float currentPitch = 0f;
    private Vector3 forwardDirection;

    void Start()
    {
        // Initialize the forward direction
        forwardDirection = transform.forward;
    }

    void FixedUpdate()
    {
        float speed = mySlider.value;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        

        // Update pitch angle (visual tilt only)
        currentPitch = Mathf.Clamp(currentPitch - verticalInput * (rotationSpeed * 0.3f) * Time.deltaTime, -maxPitchAngle, maxPitchAngle);

        // Rotate around Y axis for turning
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        // Update forward direction to match Y rotation but not pitch
        forwardDirection = Quaternion.Euler(0, transform.eulerAngles.y, 0) * Vector3.forward;

        // Apply visual pitch without affecting movement direction
        transform.rotation = Quaternion.Euler(currentPitch, transform.eulerAngles.y, 0);

        // Move in the forward direction (ignoring pitch)
        transform.position += forwardDirection * speed * Time.deltaTime;

        // Add direct vertical movement
        transform.position += Vector3.up * verticalInput * verticalSpeed * Time.deltaTime;
    }
}