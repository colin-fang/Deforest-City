using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Location : MonoBehaviour
{

    public Catalogue itemsFound;
    public int plantCount1;
    public int plantCount2;
    public int plantCount3;

    public int minplant1 = 1;
    public int maxplant1 = 3;
    public int minplant2 = 1;
    public int maxplant2 = 4;
    public int minplant3 = 1;
    public int maxplant3 = 5;
    

    public int stage = 1;

    public Image image;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;


    public string scene1;
    public string scene2;
    public string scene3;



    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();

        while (itemsFound.items.Count > 0)
        {
            switch (itemsFound.items.Dequeue().itemName)
            {
                case "Tree Type1 01":
                    plantCount1 += 1;
                    break;
                case "Tree Type1 02":
                    plantCount2 += 1;
                    break;
                case "Tree Type1 03":
                    plantCount3 += 1;
                    break;
            }
        }
        if(minplant1 < plantCount1 && plantCount1 < maxplant1 
            && minplant2 < plantCount2 && plantCount2 < maxplant2 
            && minplant3 < plantCount3 && plantCount3 < maxplant3)
        {
            if(stage < 3)
            {
                stage += 1;
            }
        }
        else
        {
            if(stage > 1)
            {
                stage -= 1;
            }
        }
        switch (stage)
        {
            case 1:
                image.sprite = sprite1;
                break;
            case 2:
                image.sprite = sprite2;
                break;
            case 3:
                image.sprite = sprite3;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void LoadScene()
    {
        switch (stage)
        {
            case 1:
                SceneManager.LoadScene(scene1);
                break;
            case 2:
                SceneManager.LoadScene(scene1);
                break;
            case 3:
                SceneManager.LoadScene(scene1);
                break;
        }
    }

}
