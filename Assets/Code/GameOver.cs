using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    GameManager _gameManager;
    public TextMeshProUGUI scoreUI;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        scoreUI.text = "Your Total Score is " + _gameManager.score;
        _gameManager.score = 0;
        _gameManager.life = 3;
    }

}
