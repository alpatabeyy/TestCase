using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXMovement : MonoBehaviour
{
    [SerializeField]
    Transform rightBorder;
    [SerializeField]
    Transform leftBorder;
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            transform.position = new Vector3(hit.point.x, transform.position.y, transform.position.z);
            if (hit.point.x < -4)
            {
                transform.position = new Vector3(-4, transform.position.y, transform.position.z);
            }
            if (hit.point.x > 4)
            {
                transform.position = new Vector3(4, transform.position.y, transform.position.z);
            }
        }
    }

}
