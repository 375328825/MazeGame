using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtr : MonoBehaviour {
    public GameObject boom;
    public Vector3 dir=new Vector3(1,0,0);
	// Use this for initialization
	void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {
        this.transform.position += dir * Time.deltaTime * 6;

        if (transform.localPosition.x > 20||Mathf.Abs(transform.localPosition.y)>10)
        {
            Destroy(gameObject);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "zomble")
        {
           Instantiate(boom, transform.position, Quaternion.identity, transform.parent);
            other.GetComponent<ZombleCtr>().healthNum--;
            Destroy(gameObject);
        }
    }
}
