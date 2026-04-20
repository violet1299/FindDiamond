using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest1: MonoBehaviour
{
    public GameObject CoinPre;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, player.position);
        if (dis < 2f && Input.GetMouseButtonDown(0))
        {
            if (UnityEngine.Random.Range(0, 10) > 5)
            {
                Instantiate(CoinPre, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}

