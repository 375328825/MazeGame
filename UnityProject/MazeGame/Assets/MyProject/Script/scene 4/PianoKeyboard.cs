using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PianoKeyboard : TouchManager {
    public GameObject key;
    public float downPix = 45;

    private bool isDown = false;

    private Vector2 idlePos = Vector2.zero;
    private RectTransform keyRectTransform;
    public AudioClip audio;
    private AudioManager audioManager;
    private Scene4Manager scene4Manager;
	// Use this for initialization
	void Start () {
        keyRectTransform = key.GetComponent<RectTransform>();
        idlePos =keyRectTransform.anchoredPosition;
        audioManager = AudioManager.Instance;
        scene4Manager = Scene4Manager.Instance;
    }
	
	// Update is called once per frame
	void Update () {
        if (isDown)
        {
            keyRectTransform.anchoredPosition = Vector3.Lerp(keyRectTransform.anchoredPosition, idlePos +Vector2.down*downPix, 0.2f);  
        }
        else
        {
            keyRectTransform.anchoredPosition = Vector3.Lerp(keyRectTransform.anchoredPosition,idlePos, 0.2f);

        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("down");
        isDown = true;
        audioManager.PlayOneShot(audio);
        scene4Manager.CheckTone(audio);
   //     this.GetComponent<RectTransform>().anchoredPosition += Vector2.down * 45;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
       // Debug.Log("up");
        isDown = false ;
    }
}
