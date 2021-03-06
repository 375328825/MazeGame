﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {
    public Image mask;
    public GameObject[] scenes;

    public GameObject food;
    public GameObject zhongzi;
    public GameObject cameraUi;
    public GameObject blackMan;
    public GameObject whiteMan;
    public GameObject pianoPaper;

  //  public GameObject[] bagItemPoses;
    protected static MainManager instance;
    private int openSceneIndex = 0;

    private GameObject hotItem;
    public GameObject[] bags=new GameObject[8];

    private BlackMask blackMask;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public GameObject HotItem { get { return hotItem; } }
	// Use this for initialization
	void Start () {
        blackMask = BlackMask.Instance;
        mask.color = new Color(0, 0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeScene(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeScene(false);

        }
    }

    public static MainManager Instance
    {
        get { return instance; }
    }
    public void AddItem(GameObject item)
    {
      
    }
    public void ChangeHotItem(int s)
    {
        Debug.Log(s);
        if (bags[s].activeSelf)
        {
            for(int i = 0; i < bags.Length; i++)
            {
                if (i == s)
                {
                    bags[i].GetComponent<ItenCtr>().BeHot();
                    hotItem = bags[i];
                    Debug.Log(hotItem.name);
                }
                else
                {
                    if (bags[i].activeSelf)
                    {
                        bags[i].GetComponent<ItenCtr>().BeCold();
                    }
                }
            }
        }
    }

    private bool isLeft = false;

    public void ChangeScene(bool left)
    {
        bool baseScene = scenes[openSceneIndex].GetComponent<BaseSceneTest>().baseScene;
        if (!baseScene)
        {
            scenes[openSceneIndex].GetComponent<BaseSceneTest>().GoBack();
            return;
        }


        isLeft = left;
        blackMask.ChangeScene("MainManagerCallBack",gameObject,0.25f);
    }
    public void MainManagerCallBack()
    {
       
        ChangeBlack(isLeft);
        
    }

    



    //IEnumerator ChangeSceneIenum(bool leftChange)
    //{
    //    isChanging = true;
    //    for (float t = 0; t < 0.5f; t += Time.deltaTime)
    //    {
    //        mask.color = new Color(0, 0, 0, t * 2);
    //        yield return 0;

    //    }
    //    ChangeBlack(leftChange);

    //    for (float t = 0.6f; t > 0; t -= Time.deltaTime)
    //    {
    //        mask.color = new Color(0, 0, 0, t * 2);
    //        yield return 0;

    //    }
    //    isChanging = false;


    //}


    private void ChangeBlack(bool leftChange)
    {
        if (leftChange)
        {
            openSceneIndex--;
            OpenScene(openSceneIndex);
            
          //  scenes[openSceneIndex].SetActive(true);
        }
        else
        {
            openSceneIndex++;
            OpenScene(openSceneIndex);
            
          //  scenes[openSceneIndex].SetActive(true);

        }
        //Debug.Log("complete");
    }
    private void OpenScene(int index)
    {
        if (index < 0)
        {
            index = 3;
            openSceneIndex = index;
        }
        if (index > 3)
        {
            index = 0;
            openSceneIndex = index;

        }
        for (int i = 0; i < 4; i++)
        {
            if (i == index)
            {
                scenes[i].SetActive(true);
            }
            else
            {
                scenes[i].SetActive(false);
            }
        }
    }
}
