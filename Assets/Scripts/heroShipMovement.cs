using UnityEngine;
using System.Collections;

public class heroShipMovement : MonoBehaviour {
    public float moveSpeed = 100f;
    public float rotSpeed = 180f;
    float boundariesRadius = 0.5f;
    
	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        //Rotation
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;
        //Movement align
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0);
        pos += rot * velocity;
        //Restrictions
            //Height
        if(pos.y + boundariesRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - boundariesRadius;
        }
        if (pos.y - boundariesRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + boundariesRadius;
        }
            //Width
        float screenRate = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRate;
        if (pos.x + boundariesRadius > widthOrtho)
        {
            pos.x = widthOrtho - boundariesRadius;
        }
        if (pos.x - boundariesRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + boundariesRadius;
        }
        //Final position
        transform.position = pos;

    }
}
