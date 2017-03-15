using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class damageHandlerPlayer : MonoBehaviour {

    
    public Image healthBarImage;
    public float maxHealth = 5f;
    public float curHealth = 0f;

    void Start()
    {
        curHealth = maxHealth;
        healthBarImage = GameObject.Find("hpBarFiller").GetComponent<Image>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
            curHealth--;
        else if (col.gameObject.tag == "Obstacle")
            curHealth = curHealth - 2;
        else if (col.gameObject.tag == "Health")
        {
            Destroy(col.gameObject);
            curHealth = maxHealth;
            GameObject.FindWithTag("Player spawner").GetComponent<playerSpawner>().numberOfSpawns++;
        }

    }

    void Die()
    {
        if (GameObject.FindWithTag("Player spawner").GetComponent<playerSpawner>().numberOfSpawns <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else Destroy(gameObject);
       
    }
    void setHealth(float myHealth)
    {
        healthBarImage.fillAmount = myHealth / maxHealth;
        if (myHealth <= 0) Die();
    }
    // Update is called once per frame
    void Update()
    {
        setHealth(curHealth);
    }
}
