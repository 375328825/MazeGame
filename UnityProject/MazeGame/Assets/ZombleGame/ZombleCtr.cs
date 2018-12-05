using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombleCtr : MonoBehaviour {
   
    public string walkAnim = "zb_walk1";
    public string deadAnim = "zb_dead2";
    public float speed = 1f;
    private Animation anim;

    public int healthNum = 10;
    public int maxHealth = 20;
    public int minHealth = 1;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
        anim.Play(walkAnim);
        healthNum = Random.Range(minHealth, maxHealth);
    }
    private bool dead=false;
    float timer = 2;
	// Update is called once per frame
	void Update () {

        if (healthNum > 0)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        else
        {
            if (!dead)
            {
                dead = true;
                anim.Play(deadAnim);
            }
            else
            {
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    Destroy(gameObject);
                }
            }
        }
        if (transform.localPosition.x < -19)
        {
            Destroy(gameObject);
        }
     
	}

    

}
