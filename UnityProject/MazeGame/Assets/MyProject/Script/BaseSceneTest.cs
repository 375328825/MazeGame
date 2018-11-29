using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSceneTest : MonoBehaviour {
    public bool baseScene = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GoBack()
    {
       // Debug.Log("send");
        SendMessage("SceneGoBack");
    }
}
