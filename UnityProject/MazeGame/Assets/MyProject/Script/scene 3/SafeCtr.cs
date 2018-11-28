using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SafeCtr : MonoBehaviour {
    public string password = "1234";
    public GameObject open;
    public GameObject close;
    public Text[] texts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //public void CheckNum()
    //{
    //    string s=null;
    //    for(int i = 0; i < 4; i++)
    //    {
    //        s += texts[i].text;
    //    }
       
    //}
    public void OpenDoor()
    {
        string s = null;
        for (int i = 0; i < 4; i++)
        {
            s += texts[i].text;
        }

        if (s == password)
        {
            open.SetActive(true);
            close.SetActive(false);
        }
    }
}
