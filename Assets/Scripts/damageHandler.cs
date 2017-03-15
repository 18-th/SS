using UnityEngine;
using System.Collections;

public class damageHandler : MonoBehaviour {

    public int health = 1;
    public float cost = 0;
    public GameObject deathPrefab;
    public AudioClip deathSound;
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag!="Enemy")
        health--;
    }
    
    void Die()
    {
        if (GameObject.FindWithTag("Player") != null)
            GameObject.Find("scoreText").GetComponent<scoreHandlerPlayer>().curScore += cost;
        GameObject go =(GameObject)Instantiate(deathPrefab, gameObject.transform.position, gameObject.transform.rotation);
        go.AddComponent<selfDestruction>();
        Destroy(gameObject);
    }
}
