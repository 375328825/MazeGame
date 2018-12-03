using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombleCtr : MonoBehaviour {
   
    public string walkAnim = "zb_walk1";
    public string deadAnim = "zb_dead2";
    public float speed = 1f;
    private Animation anim;

    private int healthNum = 10;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
        anim.Play(walkAnim);
    }
	
	// Update is called once per frame
	void Update () {

        if (healthNum > 0)
        {
            transform.position += Vector3.left * Time.deltaTime* speed;
        }

	}



}
