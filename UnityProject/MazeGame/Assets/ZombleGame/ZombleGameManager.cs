using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombleGameManager : MonoBehaviour {
    public Transform father;
    public Transform[] instantiatePoses;
    public GameObject[] zombles;
    public GameObject ShootHead;
    public GameObject shootPos;
    public GameObject bullet;
    public int bulletNum = 0;
    // Use this for initialization
    void Start () {
		for(int i = 0; i < 5; i++)
        {
            Instantiate(zombles[Random.Range(0, 4)], instantiatePoses[i].position, Quaternion.identity, father);

        }
    }
    float timer = 3;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            InstantiateZomble();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Shoot();
        }
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            InstantiateZomble();
            timer = Random.Range(1, 6);
        }

    }

    public void SetHeadRotation(Vector3 v)
    {
        ShootHead.transform.eulerAngles = v;
    }

    public void Shoot(Vector3 v)
    {
        if (bulletNum <= 0)
        {
            return;
        }
        bulletNum--;
       GameObject g= Instantiate(bullet, shootPos.transform.position, Quaternion.identity, father);
        g.GetComponent<BulletCtr>().dir = v;
    }
    public void InstantiateZomble()
    {
        Instantiate(zombles[Random.Range(0, 4)], instantiatePoses[Random.Range(0, 5)].position, Quaternion.identity, father);
    }
}
