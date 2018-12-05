using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZombleGameTouch : TouchManager {
    public ZombleGameManager zgm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void OnPointerClick(PointerEventData eventData)
    {


        Vector2 dir = (eventData.position - new Vector2(307.3f, 558.5f)).normalized;
        float eulerAngles = Vector2.Angle(new Vector2(1, 0), dir);

        if (eventData.position.y < 558.5)
        {
            eulerAngles = -eulerAngles;
        }
        zgm.SetHeadRotation(new Vector3(0, 0, eulerAngles));
        zgm.Shoot(dir);

    }
}
