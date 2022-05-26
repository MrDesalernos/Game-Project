using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    static int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score " + score.ToString() + "/20";
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score " + score.ToString() + "/20";
        if (score == 20)
        {
            SceneManager.LoadScene(2);
        }
    }
    // Update is called once per frame
}
