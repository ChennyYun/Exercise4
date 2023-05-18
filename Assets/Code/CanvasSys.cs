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
    //private int scoreTolife;
    public int levelTransition=0;
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
        if (time <= 0 && levelTransition==0)
        {
            nextLevel();
            time = 10;
        }
        //change score to life
        // scoreTolife = _gameManager.score;
        // if(scoreTolife%50 != 0){
        //     _gameManager.ChangeLife(scoreTolife%50);
        //     scoreTolife = 0;
        // }
        

    }

    void nextLevel(){
        if (level == 0){
            SceneManager.LoadScene("LevelTransition1");
        }
        else if (level == 1) {
            SceneManager.LoadScene("LevelT2");
        }
        else if (level == 2) {
            //print("hi");
            SceneManager.LoadScene("LevelT3");
            
        }
        else if (level == 3) {
            SceneManager.LoadScene("Win");
        }
        else {
            SceneManager.LoadScene("Over");
        }
    }
}
