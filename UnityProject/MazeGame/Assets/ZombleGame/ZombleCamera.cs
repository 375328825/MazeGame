using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZombleCamera : MonoBehaviour {
    MainManager mainManger;
	// Use this for initialization
	void Start () {
        mainManger = MainManager.Instance;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(Move());
        }
	}
    private void OnEnable()
    {
        StartCoroutine(Move());
    }
    IEnumerator Move()
    {
        for(float t = 0; t < 0.6f; t += Time.deltaTime)
        {
            transform.localPosition += Vector3.up * Time.deltaTime*6f;
            yield return 0;
        }

        for (float t = 0; t < 0.4f; t += Time.deltaTime)
        {
            transform.localPosition -= Vector3.up * Time.deltaTime *5f;
            yield return 0;
        }
        for (float t = 0; t < 4; t += Time.deltaTime)
        {
            //transform.localPosition -= Vector3.up * Time.deltaTime * 5f;
            yield return 0;
        }
        mainManger.cameraUi.SetActive(true);
        this.gameObject.SetActive(false);
    }
  
}
