using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private Vector3 initialPosition;   // ��ʼλ��
    private Quaternion initialRotation; // ��ʼ��ת


    void Start()
    {
        // ��¼��ʼλ�ú���ת
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