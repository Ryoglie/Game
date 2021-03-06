﻿using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public GameObject explosionPrefab; //爆発エフェクトのprefab


	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0.2f, 0);

        if(transform.position.y>5){
            Destroy(gameObject);
        }
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
        //スコア更新
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
        //爆発エフェクト
        //GameObject effect=
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        //Destroy(effect, 1.0f);

        Destroy(coll.gameObject);
        Destroy(gameObject);
	}
}
