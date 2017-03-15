using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour {

    public string levelToLoad;

	public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

}
