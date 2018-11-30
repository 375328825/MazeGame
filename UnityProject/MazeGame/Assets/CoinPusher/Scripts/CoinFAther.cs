using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFAther : MonoBehaviour
{
    bool left = false;
    public GameObject coinPrefab;
    public GameObject coin;
    // Use this for initialization
    void Start()
    {
        coin = GameObject.Instantiate(coinPrefab, transform.position, coinPrefab.transform.rotation, transform);
    }

    // Update is called once per frame
    void Update()
    {
   
        if (transform.localPosition.x >= 1.5f)
        {

            left = true;
        }
        else if (transform.localPosition.x <= -1.5f)
        {
            left = false;
        }
        if (left)
        {
            transform.localPosition += Vector3.left * Time.deltaTime;
        }
        else
        {
            transform.localPosition -= Vector3.left * Time.deltaTime;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coin == null)
            {
                return;
            }

            coin.GetComponent<Rigidbody>().isKinematic = false;

            coin.GetComponent<Rigidbody>().velocity = transform.forward * 9;
            coin.transform.parent = null;
            coin = null;
            Invoke("InstantCoin", 0.3f);
        }
    }

    public void InstantCoin()
    {
        coin = GameObject.Instantiate(coinPrefab, transform.position, coinPrefab.transform.rotation, transform);

       // yield return 0;
    }
}
