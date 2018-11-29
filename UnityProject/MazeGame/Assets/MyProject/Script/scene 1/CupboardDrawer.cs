using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CupboardDrawer : TouchManager
{
    float moveDistance = 202f;
    Vector2 startPos= Vector2.zero;
    bool open = false;

    RectTransform rectTran;
	// Use this for initialization
	void Start () {
        rectTran = GetComponent<RectTransform>();

        startPos = rectTran.anchoredPosition;

	}
	
	// Update is called once per frame
	void Update () {
        if (open)
        {
            rectTran.anchoredPosition = Vector2.Lerp(rectTran.anchoredPosition, startPos - Vector2.up * moveDistance, 0.2f);
        }
        else
        {
            rectTran.anchoredPosition = Vector2.Lerp(rectTran.anchoredPosition, startPos, 0.2f);

        }
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        open = !open;


    }

}
