using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeed : MonoBehaviour
{
    public GameObject tree;
    public static Queue<GameObject> treeAdded;
    public Catalogue itemsFound;
    public Catalogue items;
    public Canvas catalogueCanvas;
    
    public Item plant1;
    public Item plant2;
    public Item plant3;

    void Start()
    {
        treeAdded = new Queue<GameObject>();
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
                    treeAdded.Enqueue(Instantiate(tree, hit.point, Quaternion.Euler(0f, 0f, 0f)));
                    if (tree.gameObject.name == "Tree Type1 01")
                    {
                        itemsFound.AddItem(plant1);
                    } 
                    else if (tree.gameObject.name == "Tree Type1 02")
                    {
                        itemsFound.AddItem(plant2);
                    } 
                    else if (tree.gameObject.name == "Tree Type1 03")
                    {
                        itemsFound.AddItem(plant3);
                    }
                }
            }
        }
    }
}
