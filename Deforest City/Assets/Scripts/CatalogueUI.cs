using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatalogueUI : MonoBehaviour
{
    public Canvas catalogueCanvas;
    public Canvas ingameCanvas;
    public GameObject seed1;
    public GameObject seed2;
    public GameObject seed3;
    
    public static GameObject seedSelected;
    private string seedName;
    
    void Start()
    {
        seedName = "";
        seedSelected = seed1;
    }
    
    public void OnClicked(Button button)
    {
        seedName = button.name;
        //Debug.Log(seedName);
    }

    public void Update()
    {
        if (seedName == "Seed 1")
        {
            seedSelected = seed1;
        } 
        else if (seedName == "Seed 2")
        {
            seedSelected = seed2;
        }
        else if (seedName == "Seed 3")
        {
            seedSelected = seed3;
        }
    }

    public void Back()
    {
        catalogueCanvas.gameObject.SetActive(false);
        ingameCanvas.gameObject.SetActive(true);
    }

    public void Show()
    {
        catalogueCanvas.gameObject.SetActive(true);
        ingameCanvas.gameObject.SetActive(false);
    }
}
