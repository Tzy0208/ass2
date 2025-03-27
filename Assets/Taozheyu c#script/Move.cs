using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour
{
    public GameObject targetObject;

    public float moveDistance = 1.0f;

    
    public float leftLimit = -5f;
    public float rightLimit = 5f;

    
    public void MoveLeft()
    {
        if (targetObject == null) return;

        Vector3 newPosition = targetObject.transform.position + Vector3.left * moveDistance;

        if (newPosition.x >= leftLimit)
        {
            targetObject.transform.position = newPosition;
        }
    }

   
    public void MoveRight()
    {
        if (targetObject == null) return;

        Vector3 newPosition = targetObject.transform.position + Vector3.right * moveDistance;

        if (newPosition.x <= rightLimit)
        {
            targetObject.transform.position = newPosition;
        }
    }
}