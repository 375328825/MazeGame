using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Curtain : TouchManager {

    public GameObject anotherCurtain;
   // public GameObject curtain_R;

    private RectTransform rectTransform;
    Vector2 size;
    private bool isOpen = false;

    // Use this for initialization
    void Start () {
        rectTransform = GetComponent<RectTransform>();
        size = rectTransform.sizeDelta;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OpenCurtain()
    {
        isOpen = true;
        rectTransform.sizeDelta = new Vector2(size.x * 0.3f, size.y);
    }
    public void CloseCurtain()
    {
        isOpen = false;

        rectTransform.sizeDelta = size;
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (isOpen)
        {
            CloseCurtain();
            anotherCurtain.GetComponent<Curtain>().CloseCurtain();
        }
        else
        {
            OpenCurtain();
            anotherCurtain.GetComponent<Curtain>().OpenCurtain();

        }
    }
}
