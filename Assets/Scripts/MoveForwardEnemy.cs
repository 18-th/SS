using UnityEngine;
using System.Collections;

public class MoveForwardEnemy : MonoBehaviour {

	public float moveSpeed = 5f;
public float rot = 180f;
// Use this for initialization
void Start()
{

}

// Update is called once per frame
void Update()
{
    Vector3 pos = transform.position;
    Vector3 velocity = new Vector3(0, moveSpeed * Time.deltaTime, 0);
    pos += transform.rotation * velocity;
    transform.position = pos;

}
}
