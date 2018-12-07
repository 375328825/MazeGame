using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TailandPicture : TouchManager {
    public GameObject black;
    public GameObject white;

    private MainManager mainManager;
	// Use this for initialization
	void Start () {
        mainManager = MainManager.Instance;

    }
	
	// Update is called once per frame
	void Update () {
		
       
	}
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (mainManager.HotItem.name == "blackMan")
        {
            black.SetActive(true);
            black.GetComponent<RectTransform>().anchoredPosition = eventData.position - new Vector2(1115 - 49, 432 + 115);
        }
        if (mainManager.HotItem.name == "whiteMan")
        {
            white.SetActive(true);

            white.GetComponent<RectTransform>().anchoredPosition = eventData.position - new Vector2(1115 - 49, 432 + 115);
        }

        //  Debug.log

    }
    //1115 432
    //49 -115
}
