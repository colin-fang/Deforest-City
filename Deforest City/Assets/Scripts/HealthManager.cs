using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject modelA;
    public GameObject modelB;

    // Start is called before the first frame update
    void Start()
    {
        modelA.SetActive(true);
        modelB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            modelA.SetActive(false);
            modelB.SetActive(true);
        }
    }
}
