using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour {
    public MainManager mainManager;
	// Use this for initialization
	void Start () {
        mainManager = MainManager.Instance;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LeftChange()
    {
        mainManager.ChangeScene(true);
    }
    public void RightChange()
    {
        mainManager.ChangeScene(false);

    }
}
