using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOver;

    private int score;

    void Start()
    {
        gameOver.SetActive(false);
        UpdateScoreText();
    }

    void Update()
    {
        if(!Playing() && Input.anyKeyDown)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Lose()
    {
        gameOver.SetActive(true);
    }

    public void IncreaseScore()
    {
        if (Playing())
        {
            score++;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public bool Playing() {
        return !gameOver.activeInHierarchy;
    }
}
