using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CameraTouchBOard : TouchManager {
    public Image near;
    public Image far;
    public GameObject touchPoint;
    private bool isNear = true;
    private bool changing = false;
	// Use this for initialization
	void Start () {
        touchPoint.GetComponent<RectTransform>().anchoredPosition = new Vector2(-66, 0);

    }
	void OnEnable()
    {
        near.color = new Color(1, 1, 1, 1);

    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(ToNear());
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            StartCoroutine(ToFar());
        }
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        touchPoint.GetComponent<RectTransform>().anchoredPosition = eventData.position;

        Debug.Log(eventData.position);
        if (eventData.position.x > 800)
        {
            if (!changing && !isNear)
            {
                StartCoroutine(ToNear());
                isNear = true;
            }
        }
        else
        {
            if (!changing && isNear)
            {
                StartCoroutine(ToFar());
                isNear = false;

            }
        }
    }

    private IEnumerator ToNear()
    {
        changing = true;
        for(float i=0;i<=1;i+= Time.deltaTime*2)
        {
            near.color = new Color(1, 1, 1, i);
          //  far.color = new Color(1, 1, 1, 1 - i);
            yield return 0;
        }
        changing = false;

    }

    private IEnumerator ToFar()
    {
        changing = true;
        for (float i = 1; i >=0; i -= Time.deltaTime*2)
        {
            near.color = new Color(1, 1, 1, i);
          //  far.color = new Color(1, 1, 1, 1 - i);

            yield return 0;
        }
        changing = false;

    }
}
