using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthBar : MonoBehaviour {

    public Image healthBarImage;
    public float maxHealth = 100f;
    public float curHealth = 0f;

	void Start () {
        curHealth = maxHealth;
	}
	void setHealth(float myHealth)
    {
        healthBarImage.fillAmount = myHealth / maxHealth;
    }
	// Update is called once per frame
	void Update () {
        setHealth(curHealth);
	}
}
