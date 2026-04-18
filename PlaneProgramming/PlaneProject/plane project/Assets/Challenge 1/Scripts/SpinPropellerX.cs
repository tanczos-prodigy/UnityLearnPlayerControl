using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float spinSpeed = 2000f;

    void Update()
    {
        // Rotate around local Z axis every frame
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f, Space.Self);
    }
}