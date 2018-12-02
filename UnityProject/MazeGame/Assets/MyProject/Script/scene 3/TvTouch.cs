using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TvTouch : TouchManager {
    Scene3Manager scene3Manager;
	// Use this for initialization
	void Start () {
        scene3Manager = Scene3Manager.Instance;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void OnPointerClick(PointerEventData eventData)
    {
        scene3Manager.OpenTV();
    }
}
