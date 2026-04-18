using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject Plane;
    private Vector3 offset;

    void Start()
    {
        // Initialize the offset as the distance between the camera and plane at start
        offset = transform.position - plane.transform.position;
    }

    void Update()
    {
        // Maintain the same offset as the plane moves
        Vector3 targetPos = plane.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.1f);
    }
}