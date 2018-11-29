using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SafeText : TouchManager {
   // public SafeCtr safeCtr;
    public Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void OnPointerClick(PointerEventData eventData)
    {
        int num =int.Parse(text.text);
        num++;
        if (num > 9)
        {
            num = 0;
        }
        text.text = num.ToString();
       //safeCtr.OpenDoor()();
    }
}
