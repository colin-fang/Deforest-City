using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    public float camSpeed = 3;
    public Touchpad cameraTouchPad;

    // Update is called once per frame
    void Update()
    {
        if (cameraTouchPad != null)
        {
            transform.RotateAround(transform.position, -Vector3.up, camSpeed * cameraTouchPad.InputVector.x);
            transform.RotateAround(transform.position, transform.right, camSpeed * cameraTouchPad.InputVector.y);
        }
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, -Vector3.up, camSpeed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, camSpeed * Input.GetAxis("Mouse Y"));
        }
    }
}
