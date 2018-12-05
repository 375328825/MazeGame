using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCoilder : MonoBehaviour {
    int score = 0;
    public ZombleGameManager zombleGameManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        zombleGameManager.bulletNum += 20;
    }
    public void Reset()
    {
        score = 0;
    }
}
