using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CanvasSys : MonoBehaviour
{
    //get score from GameManager
    public TextMeshProUGUI scoreUI;
    public int level;
    public TextMeshProUGUI levelUI;
    //get life from GameManager
    public TextMeshProUGUI lifeUI;
    public float time = 10f;
    public TextMeshProUGUI timeUI;
    GameManager _gameManager;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        // scoreUI.text = "Score: " + _gameManager.score;
        // levelUI.text = "Level " + level;
        // lifeUI.text = "Life: " + _gameManager.life;
        // timeUI.text = "Ends In: " + time + "s";
    }

    void Update()
    {
        scoreUI.text = "Score: " + _gameManager.score;
        levelUI.text = "Level " + level;
        lifeUI.text = "Life: " + _gameManager.life;
        int timeInt = (int)time;
        timeUI.text = "Ends In: " + timeInt + "s";
        time -= Time.deltaTime;
        if (time <= 0)
        {
            nextLevel();
            time = 30;
        }
    }

    void nextLevel(){
        if (level == 0){
            SceneManager.LoadScene("Level 1");
        }
        else if (level == 1) {
            SceneManager.LoadScene("Level 2");
        }
        else if (level == 2) {
            //print("hi");
            SceneManager.LoadScene("Level3");
            
        }
        else {
            SceneManager.LoadScene("Over");
        }
    }
}
