using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorDetection : MonoBehaviour
{
    //This script should detect an item within a box collider and add the item to the catalogue scriptable object
    
    public BoxCollider detectionArea;
    public Catalogue itemsFound;
    public Catalogue items;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plant") && !other.isTrigger)
        {
            switch (other.name){
                case "PlantA":
                    itemsFound.AddItem(items.GetItem("PlantA"));
                    Debug.Log(other.name);
                    break;
                case "PlantB":
                    itemsFound.AddItem(items.GetItem("PlantB"));
                    Debug.Log(other.name);
                    break;
                case "PlantC":
                    itemsFound.AddItem(items.GetItem("PlantC"));
                    Debug.Log(other.name);
                    break;
            }
        }
    }
    private void OnCollisionExit(Collider other)
    {
        if (other.CompareTag("Plant") && !other.isTrigger)
        {
            switch (other.name)
            {
                case "PlantA":
                    itemsFound.RemoveItem(items.GetItem("PlantA"));
                    break;
                case "PlantB":
                    itemsFound.RemoveItem(items.GetItem("PlantB"));
                    break;
                case "PlantC":
                    itemsFound.RemoveItem(items.GetItem("PlantC"));
                    break;
            }
        }
    }
}
