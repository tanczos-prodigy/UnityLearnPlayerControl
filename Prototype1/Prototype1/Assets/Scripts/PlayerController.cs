using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float HorizonalInput;
    private float ForwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizonalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        // moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);

        //rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * HorizonalInput * Time.deltaTime);
    }
}     
