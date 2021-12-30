using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorDetection : MonoBehaviour
{
    //This script should detect an item within a box collider and add the item to the catalogue scriptable object
    
    public BoxCollider detectionArea;
    public Catalogue catalogue;
    public Item item;
    


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
            catalogue.AddItem(item);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plant") && !other.isTrigger)
        {
            catalogue.RemoveItem(item);
        }
    }
}
