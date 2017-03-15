﻿using UnityEngine;
using System.Collections;

public class enemyShot : MonoBehaviour {

    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 2.0f;
    float cooldownTimer = 0;
    Transform player;
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            GameObject go = GameObject.FindWithTag("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }
        cooldownTimer -= Time.deltaTime;
        if(cooldownTimer<=0 && player!=null && Vector3.Distance(transform.position,player.position)<8.0)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = gameObject.layer;
            bulletGO.tag = gameObject.tag;
        }
	
	}
}