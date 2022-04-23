using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeed : MonoBehaviour
{
    public GameObject tree;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject randTree;
    public Catalogue itemsFound;
    public Catalogue items;
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
                if (hit.transform.gameObject.CompareTag("Terrain"))
                {
                    Instantiate(randTree, hit.point, Quaternion.Euler(0f, 0f, 0f)).transform.localScale = 
                        new Vector3(1f, 1f, 1f);
                    if (randTree == tree)
                    {
                        itemsFound.AddItem(items.GetItem("Tree Type1 01"));
                        randTree = tree2;
                    }else if (randTree == tree2)
                    {
                        itemsFound.AddItem(items.GetItem("Tree Type1 02"));
                        randTree = tree3;
                    }else if (randTree == tree3)
                    {
                        itemsFound.AddItem(items.GetItem("Tree Type1 03"));
                        randTree = tree;
                    }
                }
            }
        }
    }
}
