using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCoilder : MonoBehaviour {
    int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        score++;
    }
    public void Reset()
    {
        score = 0;
    }
}
