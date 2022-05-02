using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeed : MonoBehaviour
{
    public GameObject tree;
    public Catalogue itemsFound;
    public Catalogue items;
    public Canvas catalogueCanvas;
    void Start()
    {
        
    }

    void Update()
    {
        tree = CatalogueUI.seedSelected;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !catalogueCanvas.gameObject.activeSelf)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.CompareTag("Terrain"))
                {
                    Instantiate(tree, hit.point, Quaternion.Euler(0f, 0f, 0f)).transform.localScale = 
                        new Vector3(1f, 1f, 1f);
                    if (tree.gameObject.name == "Tree Type1 01")
                    {
                        itemsFound.AddItem(items.GetItem("Tree Type1 01"));
                    } else if (tree.gameObject.name == "Tree Type1 02")
                    {
                        itemsFound.AddItem(items.GetItem("Tree Type1 02"));
                    } else if (tree.gameObject.name == "Tree Type1 03")
                    {
                        itemsFound.AddItem(items.GetItem("Tree Type1 03"));
                    }
                }
            }
        }
    }
}
