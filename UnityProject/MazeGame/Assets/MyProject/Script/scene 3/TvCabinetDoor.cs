using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TvCabinetDoor : TouchManager {
    public TvCabinetCtr tvCabinetCtr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void OnPointerClick(PointerEventData eventData)
    {
        tvCabinetCtr.ChangeDoorState();
    }
    

    
}
