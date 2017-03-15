using UnityEngine;
using System.Collections;

public class selfDestruction : MonoBehaviour {
    public float timer = 1f;
	
	void Update () {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            Destroy(gameObject);
        }
	
	}
}
