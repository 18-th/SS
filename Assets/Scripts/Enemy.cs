using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float level = 1f;
    public float health = 5f;
    public float speed = 5f;
    Transform targetPosition;
    public GameObject targ;

	// Use this for initialization
	void Start () {
        health = 1 * level;
        targ = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
