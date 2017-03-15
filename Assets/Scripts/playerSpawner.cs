using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerSpawner : MonoBehaviour {

    public int numberOfSpawns = 3;
    public GameObject playerPrefab;
    GameObject playerInstance;
    public Text livesAmountCounter;
    public float respawnTimer = 1.0f;
	// Use this for initialization
	void Start () {
        spawnPlayer();
        livesAmountCounter = GameObject.Find("livesAmountText").GetComponent<Text>(); 
	}
	void spawnPlayer()
    {
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
        respawnTimer = 1.0f;
    }
	// Update is called once per frame
	void Update () {
        livesAmountCounter.text = "Lives: " + numberOfSpawns;
        if (playerInstance == null && numberOfSpawns>0)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                spawnPlayer();
                numberOfSpawns--;
            }
        }
	
	}
}
