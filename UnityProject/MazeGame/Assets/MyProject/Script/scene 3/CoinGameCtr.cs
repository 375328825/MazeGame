using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoinGameCtr : TouchManager {
    public CoinFAther cf;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void OnPointerClick(PointerEventData eventData)
    {
        cf.Shoot();
    }
}
