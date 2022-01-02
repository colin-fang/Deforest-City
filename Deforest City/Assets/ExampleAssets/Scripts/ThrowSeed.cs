using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ThrowSeed : MonoBehaviour
{
    public GameObject tree;
    public GameObject seedBag;
    public ARRaycastManager rayManager;
    public ARPlaneManager PlaneManager;

    public float forceFactor = 100f;
    
    float touchTimeStart, touchTimeEnd, timeInterval;
    private Vector3 startPos, endPos, direction;
    private Rigidbody rb;

    private bool isThrew;

    public UnityEngine.UI.Text temp;
        
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 7, 5f));
        isThrew = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !isThrew)
        {
            startPos = Input.GetTouch(0).position;
            startPos.z = transform.position.z - Camera.main.transform.position.z;
            startPos = Camera.main.ScreenToWorldPoint(startPos);
            touchTimeStart = Time.time;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && !isThrew)
        {
            endPos = Input.GetTouch(0).position;
            endPos.z = transform.position.z - Camera.main.transform.position.z;
            endPos = Camera.main.ScreenToWorldPoint(endPos);
            touchTimeEnd = Time.time;
            
            timeInterval = touchTimeEnd - touchTimeStart;
            direction = endPos - startPos;
            direction.z = direction.magnitude;
            direction /= timeInterval;

            rb.useGravity = true;
            rb.isKinematic = false;
            
            rb.AddForce(direction * forceFactor);

            isThrew = true;
            Invoke("ResetSeed", 2f);
        }
        */
        
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
        Instantiate(tree, hits[0].pose.position, Quaternion.Euler(-90f, 180f, 0f));

        temp.text = Camera.main.transform.localEulerAngles.ToString();

    }
    
    /*
    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Vector3 pos = contact.point;
        
        //List<ARRaycastHit> hits = new List<ARRaycastHit>();
        //rayManager.Raycast(pos, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
        //Instantiate(tree, hits[0].pose.position, Quaternion.Euler(-90f, 180f, 0f));
        Instantiate(tree, pos, Quaternion.Euler(-90f, 180f, 0f));
        
        gameObject.SetActive(false);
    }
    */

    void ResetSeed()
    {
        gameObject.SetActive(true);
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 7, 5f));
        transform.localEulerAngles = new Vector3(-90f, -180f, 0f);
        rb.useGravity = false;
        rb.isKinematic = true;
        isThrew = false;
    }
}
