using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {
    public Image mask;


    private GameObject hotItem;
    private GameObject[] bags=new GameObject[8];
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(ChangeScene());
        }
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











    IEnumerator ChangeScene()
    {
        for (float t = 0; t < 0.5f; t += Time.deltaTime)
        {
            mask.color = new Color(0, 0, 0, t * 2);
            yield return 0;

        }
        ChangeComplete();

        for (float t = 0.6f; t > 0; t -= Time.deltaTime)
        {
            mask.color = new Color(0, 0, 0, t * 2);
            yield return 0;

        }
        
     
    }
    private void ChangeComplete()
    {
        Debug.Log("complete");
    }
}
