using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 _offset;
    public Transform target;
    private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;

    private void Awake()
    {
       // _offset = transform.position = target.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPostition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPostition, ref _currentVelocity, smoothTime);
    }
}
