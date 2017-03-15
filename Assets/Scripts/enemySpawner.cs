using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
    public GameObject enemyPrefab;
    public int amountOfEnemies = 5;
    public float enemyRate = 5.0f;
    public float nextEnemy = 1.0f;
    public float waitingTime = 1.0f;
    // Update is called once per frame

    void Update()
    {
        waitingTime -= Time.deltaTime;
        if(waitingTime<=0)
        { 
        nextEnemy -= Time.deltaTime;
        if (nextEnemy <= 0 && amountOfEnemies > 0)
        {
            nextEnemy = enemyRate;
            spawnObject();
        }
    }
	}
    void spawnObject()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
        amountOfEnemies--;
    }
}
