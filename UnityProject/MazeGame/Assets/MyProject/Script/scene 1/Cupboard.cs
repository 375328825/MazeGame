using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cupboard : TouchManager {
    private Scene1Manager scene1Manager;
	// Use this for initialization
	void Start () {
        scene1Manager = Scene1Manager.Instance;
       // Debug.Log(scene1Manager);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void OnPointerClick(PointerEventData eventData)
    {
        scene1Manager.OpenCupBoard();
       // Debug.Log("cc");
    }
}
