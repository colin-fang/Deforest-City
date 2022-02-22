using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Touchpad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{

    private Vector2 inputVector;
    public Vector2 InputVector{ get { return inputVector; } }
    private bool isDragging;
    private RectTransform rect;

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDragging)
        {
            return; //do nothing for now
        }

        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Moved)
            {
                //inputVector.y = touch.deltaposition.y;
                //inputVector.x = touch.deltaposition.x;
                inputVector.Normalize();
            }
            else if(touch.phase == TouchPhase.Stationary)
            {
                inputVector = Vector2.zero;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                inputVector = Vector2.zero;
            }
        }
    }
}
