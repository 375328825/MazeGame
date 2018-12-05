using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    //public AudioClip audioClip;

    public AudioSource audioSource;

    protected static AudioManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public static AudioManager Instance { get { return instance; } }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    public void PlayOneShot(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);

    }
}
