using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlackMask : MonoBehaviour {
    public bool isChanging = false;

    public delegate void CallBask();
    protected static BlackMask instant;
    private Image mask;

 

    
    // Use this for initialization
    void Start () {
        if (instant == null)
        {
            instant = this;
        }
        //  CallBack();
        mask = GetComponent<Image>();
    }
	public static BlackMask Instance
    {
        get { return instant; }
    }
	// Update is called once per frame
	void Update () {
		
	}



    public void ChangeScene(string methodName,GameObject g,float time)
    {
        if(!isChanging)
            StartCoroutine(ChangeSceneIenum(methodName,g, time));
    }

    IEnumerator ChangeSceneIenum(string methodName, GameObject g, float time)
    {
        isChanging = true;
        for (float t = 0; t < time; t += Time.deltaTime)
        {
            mask.color = new Color(0, 0, 0, t/time);
            yield return 0;

        }
        mask.color = new Color(0, 0, 0, 1);
        g.SendMessage(methodName);

        for (float t = time; t > 0; t -= Time.deltaTime)
        {
            mask.color = new Color(0, 0, 0, t / time);
            yield return 0;

        }
        mask.color = new Color(0, 0, 0, 0);


        isChanging = false;


    }

    void Do(CallBask h)
    {
        h();
    }
}
