using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TvManager : MonoBehaviour {
    public Image black;
    public GameObject[] Channels;

    public GameObject zombleGameObj;
    public GameObject CoinGameObj;
    private bool open = false;
    private int channelIndex = 0;
	// Use this for initialization
	void Start () {
		
	}
	void OnEnable()
    {
        black.color = new Color(0, 0, 0, 1);
        open = false;
        CoinGameObj.SetActive(true);
        zombleGameObj.SetActive(true);
    }
    void OnDisable()
    {
        CoinGameObj.SetActive(false);
        zombleGameObj.SetActive(false);

    }
    // Update is called once per frame
    void Update () {
		
	}
    public void ClickOpen()
    {
        if (!open)
        {
            StartCoroutine("Open",1.5f);
        }
        else
        {
            StartCoroutine("Close",1.5f);

        }
        open = !open;
    }
    public void CloseTV()
    {

    }
    public void ChangeCoin()
    {
        if (channelIndex == 0 || !open)
        {
            return;
        }
        channelIndex = 0;
      StartCoroutine(OpenAndClose(4));
    }
    public void ChangeZombie()
    {
        if (channelIndex == 1 || !open)
        {
            return;
        }
        channelIndex = 1;

        StartCoroutine(OpenAndClose(4));
    }
    private IEnumerator OpenAndClose(float time)
    {
        for (float i = 0; i <= 1; i += Time.deltaTime * time)
        {
            black.color = new Color(0, 0, 0, i);
            yield return 0;

        }
        black.color = new Color(0, 0, 0, 1);

        if (channelIndex == 0)
        {
            Channels[0].SetActive(true);
            Channels[1].SetActive(false);
        }
        else if (channelIndex == 1)
        {
            Channels[0].SetActive(false);
            Channels[1].SetActive(true);
        }

        for (float i = 1; i >= 0; i -= Time.deltaTime * time)
        {
            black.color = new Color(0, 0, 0, i);
            yield return 0;
        }
        black.color = new Color(0, 0, 0, 0);

       

  
    }

    


    private IEnumerator Open(float time)
    {
        for(float i = 1; i >= 0; i -= Time.deltaTime*time)
        {
            black.color = new Color(0, 0, 0, i);
            yield return 0;
        }
        black.color = new Color(0, 0, 0, 0);
        black.gameObject.SetActive(false);
    }
    private IEnumerator Close(float time)
    {
        black.gameObject.SetActive(true);

        for (float i = 0; i <= 1; i += Time.deltaTime*time)
        {
            black.color = new Color(0, 0, 0, i);
            yield return 0;

        }
        black.color = new Color(0, 0, 0, 1);

    }

}
