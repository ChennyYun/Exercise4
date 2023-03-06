using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    public int level = 0;
    public float time = 60f;
    public int life = 3;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI timeUI;
    public TextMeshProUGUI levelUI;
    public TextMeshProUGUI lifeUI;
    private void Awake()
    {
        // if (FindObjectsOfType<GameManager>().Length > 1)
        // {
        //     // Destroy(gameObject);
        // }
        // else
        // {
        //     DontDestroyOnLoad(gameObject);
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = "Score: " + score;
        timeUI.text = "Ends In: " + time + "s";
        levelUI.text = "Level " + level;
        lifeUI.text = "Life: " + life;
    }

    public void AddScore(int points)
    {
        score += points;
        scoreUI.text = "Score: " + score;
    }

    public void AddLife()
    {
        life += 1;
        lifeUI.text = "Life: " + life;
    }

    // Update is called once per frame
    void Update()
    {
#if !UNITY_WEBGL
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
#endif
        int timeInt = (int)time;
        timeUI.text = "Ends In: " + timeInt + "s";
        time -= Time.deltaTime;
        if (time <= 0)
        {
            nextLevel();
            time = 60;
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
            SceneManager.LoadScene("Level3");
        }
        else {
            SceneManager.LoadScene("Over");
        }
    }
}
