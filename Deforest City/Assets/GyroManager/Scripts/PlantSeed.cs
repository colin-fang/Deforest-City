using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlantSeed : MonoBehaviour
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
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.CompareTag("Plane"))
                {
                    Instantiate(tree, hit.point, Quaternion.Euler(-90f, 180f, 0f)).transform.localScale = 
                        new Vector3(0.1f, 0.1f, 0.1f);
                }
            }
        }
    }
}
