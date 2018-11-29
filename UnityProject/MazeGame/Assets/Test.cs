using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Test : MonoBehaviour {




    // Use this for initialization
    void Start () {

        GetComponent<Text>().text = Screen.width.ToString() + "*" + Screen.height.ToString();
	}
	
	// Update is called once per frame
	void Update () {
       
  
	}

}
