using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public static CameraFollow inst;

    private void Awake()
    {
        inst = this;
    }
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;

        transform.position = desiredPosition;

        transform.LookAt(target);
    }
}
