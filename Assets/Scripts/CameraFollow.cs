using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moves the camera to follow the target
// Should be attached to the Camera GameObject
public class CameraFollow : MonoBehaviour
{
    // The camera's offset from the target
    private Vector3 offset = new Vector3(0.0f, 0.0f, -10.0f);
    // The time it takes the camera to reach the target
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    // Set the target in the Inspector
    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // The camera's target position
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    // Puts the camera back at the start
    public void Reset()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
