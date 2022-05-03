using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(25, -9, 1);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 200);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.right * 100);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.up * 100);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        }

    }

}
