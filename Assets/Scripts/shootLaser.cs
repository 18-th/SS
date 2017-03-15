using UnityEngine;
using System.Collections;

public class shootLaser : MonoBehaviour {

    float cooldownTimer = 0f;
    float fireDelay = 0.25f;
    Vector3 bulletCoordChange = new Vector3(0, 1.0f, 0);
    public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cooldownTimer -= Time.deltaTime;
        if(Input.GetKey(KeyCode.Space) && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + bulletCoordChange, transform.rotation);
            bulletGO.layer = gameObject.layer;
        }
	
	}
}
