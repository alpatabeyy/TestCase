using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour {
    private void Update()
    {
        Throw();
    }
    void Throw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<PlayerXMovement>().enabled = false;
            GetComponent<Rigidbody>().velocity = Vector3.forward * 20;
            GetComponent<PlayerThrow>().enabled = false;
        }
    }
}
