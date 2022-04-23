using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    public GameObject[] getCount1;
    public GameObject[] getCount2;
    public GameObject[] getCount3;

    private int count1;
    private int count2;
    private int count3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Finish()
    {
        if (Input.GetButtonUp("BUTTON")) {
            getCount1 = GameObject.FindGameObjectsWithTag("Plant");
            count1 = getCount1.Length;
		
            getCount2 = GameObject.FindGameObjectsWithTag("Plant 2");
            count2 = getCount2.Length;
		
            getCount3 = GameObject.FindGameObjectsWithTag("Plant 3");
            count3 = getCount3.Length;
            Debug.Log(count1);
            Debug.Log(count2);
            Debug.Log(count3);
            if ((count1 > 2) && (count1 < 5)){
                if ((count2 > 4) && (count2 < 10)){
                    if ((count3 > 0) && (count3 < 4)){
                        //NEXT SCENE
                        Debug.Log("Met");
                    }
                }
            }
        }
    }
}
