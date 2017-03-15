using UnityEngine;
using System.Collections;

public class meteoriteSpawner : MonoBehaviour {
    public GameObject meteoritePrefab;
    public int amountOfMeteorites = 5;
    public float meteoriteRate = 5.0f;
    public float nextMeteorite = 1.0f;
    public float spawnDistance = 2f;
    public float waitingTime = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        waitingTime -= Time.deltaTime;
        if(waitingTime<=0)
        { 
        nextMeteorite -= Time.deltaTime;
        if (nextMeteorite <= 0 && amountOfMeteorites > 0)
        {
            nextMeteorite = meteoriteRate;
            spawnObject();
        }
    }
	}
    void spawnObject()
    {
        Vector3 offset = Random.onUnitSphere;
        offset.z = 0;
        offset = offset.normalized * spawnDistance;
        GameObject go = (GameObject)Instantiate(meteoritePrefab, transform.position+offset, Quaternion.identity);
        Rigidbody2D rig = go.GetComponent<Rigidbody2D>();
        rig.velocity = new Vector2(Random.Range(-5f,10f), Random.Range(-5f,10f));
        amountOfMeteorites--;
    }
}
