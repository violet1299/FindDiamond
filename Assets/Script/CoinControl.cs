using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CoinControl : MonoBehaviour
    {
        public GameObject EffectPre;
               Transform player;
        public static int Count = 0;
        AudioSource audioSource;
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindWithTag("Player").transform.GetChild(0);
            audioSource = GetComponent<AudioSource>();

        }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, player.position);
        if (dis < 1.5f)
        {
            Count++;
            audioSource.PlayOneShot(Resources.Load<AudioClip>("Coin/coin_01"));
            UnityEngine.Debug.Log("当前金币为:" + Count);

            if (Count >= 3)
            {
                GameObject go = Instantiate(EffectPre, transform.position, transform.rotation);
                Destroy(go, 8f);
                UnityEngine.Debug.Log("你胜利了");
            }
            Destroy(this);
            Destroy(gameObject, 0.3f);
        }
    }

    }


