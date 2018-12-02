using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Manager : MonoBehaviour {
    public GameObject pianoObj;
    public GameObject button;
    private MainManager mainManager;
    private BlackMask blackMask;

	// Use this for initialization
	void Start () {
        mainManager = MainManager.Instance;
        blackMask = BlackMask.Instance;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OpenPiano()
    {
        blackMask.ChangeScene("OpenPianoCallBack", gameObject, 0.16f);
    }
    public void OpenPianoCallBack()
    {
        pianoObj.SetActive(true);
        button.SetActive(false);
        GetComponent<BaseSceneTest>().baseScene = false;
    }
    public void SceneGoBack()
    {
        blackMask.ChangeScene("ClosePianoCallBack", gameObject, 0.16f);

    }
    public void ClosePianoCallBack()
    {
        button.SetActive(true);

        pianoObj.SetActive(false);
        GetComponent<BaseSceneTest>().baseScene = true;

    }
}
