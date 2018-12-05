using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Manager : MonoBehaviour {
    public GameObject pianoObj;
    public GameObject button;
    private MainManager mainManager;
    private BlackMask blackMask;

    protected static Scene4Manager instance;

    public AudioClip[] tones;
    private AudioManager am;
    //7 7 7 6#   7 2. 2. 3.3.3.2. 7 3. 2.
    // Use this for initialization
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public static Scene4Manager Instance { get { return instance; } }
    void Start () {
        mainManager = MainManager.Instance;
        blackMask = BlackMask.Instance;
        am = AudioManager.Instance;
    }
   
	// Update is called once per frame
	void Update () {
  
	}

    private int toneIndex = 0; 
    public void CheckTone(AudioClip c)
    {
        // Debug.Log(c.name);
        if (c == tones[toneIndex]) {
            toneIndex++;

            if (toneIndex > 13) {
                Debug.Log("success");
                toneIndex = 0;
            }

        }
        else
        {
            toneIndex = 0;
        }
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
