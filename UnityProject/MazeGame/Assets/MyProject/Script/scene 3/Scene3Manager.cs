using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Manager : MonoBehaviour {
    public GameObject tv;
    private MainManager mainManager;
    private BlackMask blackMask;
    protected static Scene3Manager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public static Scene3Manager Instance
    {
        get { return instance; }
    }

	// Use this for initialization
	void Start () {
        mainManager = MainManager.Instance;
        blackMask = BlackMask.Instance;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenTV()
    {
        blackMask.ChangeScene("OpenTvCallBack", gameObject, 0.16f);
    }
    public void OpenTvCallBack()
    {

        tv.SetActive(true);
        GetComponent<BaseSceneTest>().baseScene = false;
    }
    public void SceneGoBack()
    {
        blackMask.ChangeScene("CloseTvCallBack", gameObject, 0.16f);

    }
    public void CloseTvCallBack()
    {
        tv.SetActive(false);
        GetComponent<BaseSceneTest>().baseScene = true;

    }
}
