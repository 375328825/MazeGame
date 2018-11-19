using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PianoKeyboard : TouchManager {
    public GameObject key;
    public float downPix = 45;

    private bool isDown = false;

    private Vector2 idlePos = Vector2.zero;
    private RectTransform keyRectTransform;
	// Use this for initialization
	void Start () {
        keyRectTransform = key.GetComponent<RectTransform>();
        idlePos =keyRectTransform.anchoredPosition;
	}
	
	// Update is called once per frame
	void Update () {
        if (isDown)
        {
            keyRectTransform.anchoredPosition = Vector3.Lerp(keyRectTransform.anchoredPosition, idlePos +Vector2.down*downPix, 0.2f);  
        }
        else
        {
            keyRectTransform.anchoredPosition = Vector3.Lerp(keyRectTransform.anchoredPosition,idlePos, 0.2f);

        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("down");
        isDown = true;
   //     this.GetComponent<RectTransform>().anchoredPosition += Vector2.down * 45;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("up");
        isDown = false ;
    }
}
