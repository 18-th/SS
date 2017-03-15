using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreHandlerPlayer : MonoBehaviour {

    
    public Image scoreBarImage;
    public Text scoreBarText;
    public float maxScore = 25f;
    public float curScore = 0f;
    public GameObject winningTextObject;
    Text winningText;

    void Start()
    {
        scoreBarImage = GameObject.Find("scoreBoard").GetComponent<Image>();
        scoreBarText = GameObject.Find("scoreText").GetComponent<Text>();
    }
    void setScore(float myScore)
    {
        scoreBarImage.fillAmount = myScore / maxScore;
        float scorePercentage = myScore / maxScore * 100;
        scoreBarText.text = scorePercentage.ToString()+"%";
        if (myScore >= maxScore)
        {
            Win();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main menu");
        }
        setScore(curScore);
    }
    void Win()
    {
        winningTextObject.SetActive(true);
        if (SceneManager.GetActiveScene().buildIndex + 1 != SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        else{
                SceneManager.LoadScene("Main menu");
            }
            
    }
        
}
