using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatalogueUI : MonoBehaviour
{
    public Canvas catalogueCanvas;
    public Canvas ingameCanvas;
    public Catalogue itemsFound;
    public Text descriptionText;

    public Button tree1;
    public Button tree2;
    public Button tree3;
    
    public GameObject seed1;
    public GameObject seed2;
    public GameObject seed3;

    public Item plant1;
    public Item plant2;
    public Item plant3;

    
    public static GameObject seedSelected;
    private string seedName;
    private string treeName;
    private string overview;

    void Start()
    {
        seedName = "";
        seedSelected = seed1;
        overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                   "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                   "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo " +
                   "consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                   "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                   "proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
    }
    
    public void OnClicked(Button button)
    {
        seedName = button.name;
        //Debug.Log(seedName);
    }

    public void OnSelected(Button button)
    {
        treeName = button.name;
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

        if (!itemsFound.items.Contains(plant1))
        {
            tree1.gameObject.SetActive(true);
        } 
        if (!itemsFound.items.Contains(plant2))
        {
            tree2.gameObject.SetActive(true);
        } 
        if (!itemsFound.items.Contains(plant2))
        {
            tree3.gameObject.SetActive(true);
        }

        if (treeName == "Tree 1")
        {
            descriptionText.text = "Tree 1 Description:\n" + overview;
        } 
        else if (treeName == "Tree 2")
        {
            descriptionText.text = "Tree 2 Description:\n" + overview;
        }
        else if (treeName == "Tree 3")
        {
            descriptionText.text = "Tree 3 Description:\n" + overview;
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
