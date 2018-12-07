using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manager : MonoBehaviour {
    public GameObject cupboard;
    public GameObject food;
    protected static Scene1Manager instance;
    private BlackMask blackMask;
    private BaseSceneTest baseSceneTest;
    private MainManager mainManager;
    public GameObject abai;
    public GameObject WhiteMan;
   public bool abaiUp = false;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    // Use this for initialization
    void Start () {
        mainManager = MainManager.Instance;
          blackMask = BlackMask.Instance;
        baseSceneTest = GetComponent<BaseSceneTest>();
    }
    public static Scene1Manager Instance
    {
        get { return instance; }
    }
	// Update is called once per frame
	void Update () {
        if (abaiUp)
        {
            abai.GetComponent<RectTransform>().anchoredPosition += Vector2.up * Time.deltaTime*25;
            if(abai.GetComponent<RectTransform>().anchoredPosition.y> -291)
            {
                abaiUp = false;
            }
        }
	}

    public void OpenCupBoard()
    {
        blackMask.ChangeScene("OpenCupboardCallBack", gameObject,0.16f);
    }
    public void OpenCupboardCallBack()
    {
        baseSceneTest.baseScene = false;
        cupboard.SetActive(true);
    }

    public void SceneGoBack()
    {
        blackMask.ChangeScene("CloseCupboard", gameObject,0.16f);

    }
    public void CloseCupboard()
    {
        cupboard.SetActive(false);
        baseSceneTest.baseScene = true;

    }
    public void GoBackCallBack()
    {
        
    }
    public void GetFood()
    {
        food.SetActive(false);
        mainManager.food.SetActive(true);
    }
    public void PushZhongzi()
    {
        if (mainManager.HotItem == null)
        {
            return;
        }
        if (mainManager.HotItem.name == "zhongzi")
        {
            mainManager.HotItem.SetActive(false);
            abaiUp = true;
        }

    }

   public void GetWhite()
    {
        WhiteMan.SetActive(false);
        mainManager.whiteMan.SetActive(true);
    }
}
