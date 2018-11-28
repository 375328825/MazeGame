using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvCabinetCtr : MonoBehaviour {
    public GameObject doorClose;
    public GameObject doorOpen;
    public bool open=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeDoorState()
    {
        open = !open;
        if (open)
        {
            doorClose.SetActive(false);
            doorOpen.SetActive(true);
        }
        else
        {
            doorClose.SetActive(true);
            doorOpen.SetActive(false);

        }
    }
}
