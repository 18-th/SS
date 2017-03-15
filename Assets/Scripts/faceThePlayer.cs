using UnityEngine;
using System.Collections;



public class faceThePlayer : MonoBehaviour {

    Transform player;
    public float rotSpeed= 360f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            GameObject targ = GameObject.FindWithTag("Player");
            if(targ !=null)
            {
                player = targ.transform;
            }
        }
        if (player == null)
            return;
        Vector3 dir = player.position - transform.position;
        dir.Normalize();
        //One minute of math :c
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRotation = Quaternion.Euler(0, 0, zAngle);
        transform.rotation =  Quaternion.RotateTowards(transform.rotation, desiredRotation, rotSpeed*Time.deltaTime);
        

	
	}
}
