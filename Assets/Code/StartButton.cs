using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //public int startScene;
    public string sceneName;
    GameManager _gameManager;
    public void StartGame(){
        _gameManager = FindObjectOfType<GameManager>();
        _gameManager.score = 0;
        _gameManager.life = 1;
        SceneManager.LoadScene(sceneName);
    }
}
