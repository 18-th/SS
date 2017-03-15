using UnityEngine;
using System.Collections;

public class camBehaviour : MonoBehaviour {
    public float dampTime = 0.15f;
    private Vector3 velocity = new Vector3();
    public Transform target;
    // Use this for initialization
    void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        if(target)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(new Vector3(target.position.x, target.position.y + 6.0f, target.position.z));
            Vector3 delta = new Vector3(target.position.x, target.position.y + 6.0f, target.position.z) - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
	
	}
}
