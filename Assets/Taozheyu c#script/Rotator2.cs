using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private Vector3 initialPosition;   // 初始位置
    private Quaternion initialRotation; // 初始旋转


    void Start()
    {
        // 记录初始位置和旋转
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    public void RotateLeft()
    {
        transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }

    public void RotateRight()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}