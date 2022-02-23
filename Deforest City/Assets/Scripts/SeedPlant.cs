using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SeedPlant : MonoBehaviour
{
    public ARRaycastManager rayManager;
    public GameObject tree;

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            rayManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (hits.Count != 0)
            {
                Instantiate(tree, hits[0].pose.position, Quaternion.Euler(-90f, 180f, 0f));
            }
        }
    }
}
