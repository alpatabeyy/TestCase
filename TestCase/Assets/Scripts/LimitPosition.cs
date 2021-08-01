using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPosition : MonoBehaviour {
    public float minX = -4.0f, maxX = 4.0f;
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x =
           Mathf.Clamp(currentPosition.x, minX, maxX);
        transform.position = currentPosition;
    }
}
