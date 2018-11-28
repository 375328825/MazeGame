using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {
    public Image mask;
    public GameObject[] scenes;

    private static MainManager instance;
    private int openSceneIndex = 0;

    private GameObject hotItem;
    private GameObject[] bags=new GameObject[8];
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {

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
        for(int i = 0; i < bags.Length; i++)
        {
            if (bags[i] == null)
            {
                bags[i] = item;
                return;
            }
        }
    }






    private bool isChanging = false;
    public void ChangeScene(bool left)
    {
        if(!isChanging)
            StartCoroutine(ChangeSceneIenum(left));

    }



    IEnumerator ChangeSceneIenum(bool leftChange)
    {
        isChanging = true;
        for (float t = 0; t < 0.5f; t += Time.deltaTime)
        {
            mask.color = new Color(0, 0, 0, t * 2);
            yield return 0;

        }
        ChangeBlack(leftChange);

        for (float t = 0.6f; t > 0; t -= Time.deltaTime)
        {
            mask.color = new Color(0, 0, 0, t * 2);
            yield return 0;

        }
        isChanging = false;


    }


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
        Debug.Log("complete");
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
