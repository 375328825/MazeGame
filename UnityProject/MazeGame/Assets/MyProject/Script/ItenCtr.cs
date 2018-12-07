using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItenCtr : MonoBehaviour {
    
    public GameObject hotLine;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BeHot()
    {
        hotLine.SetActive(true);
    }
    public void BeCold()
    {

        hotLine.SetActive(false);
    }

}
