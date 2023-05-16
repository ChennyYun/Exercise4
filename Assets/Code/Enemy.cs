using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    int speed;
    int pointValue = 10;
    Rigidbody2D _rigidbody2D;
    public GameObject explosion;
    public GameObject boots;
    public GameObject milk;
    GameManager _gameManager;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(40, 100);
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(new Vector2(-speed, 0));
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Bullet")) {
            _gameManager.AddScore(pointValue);
            // // change score to life
            // if(_gameManager.score>=50){
            //     _gameManager.ChangeLife(1);
            //     _gameManager.score -= 50;
            // }
            // //
            Instantiate(explosion, transform.position, Quaternion.identity);
            int randomVal = Random.Range(0, 10);
            if(randomVal == 0) {
                Instantiate(boots, transform.position, Quaternion.identity);
            }
            if(randomVal == 1) {
                Instantiate(milk, transform.position, Quaternion.identity);
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if(other.CompareTag("Kill")) {
            Destroy(gameObject);
        }

        // if(other.CompareTag("Player") && _gameManager.level < 0) {
        //     _gameManager.ChangeLife(-1);
        //add partical system
        //use a function in the Player ot change color
        //     if(_gameManager.life == -1)
        //     {
        //         Destroy(other.gameObject);
        //         Destroy(gameObject);
        //         SceneManager.LoadScene(sceneName);
        //     }
        // }

        // if(other.CompareTag("Player") && _gameManager.level != 3) {
        //     Destroy(other.gameObject);
        //     Destroy(gameObject);
        //     SceneManager.LoadScene(sceneName);
        // }
        if(other.CompareTag("Player")) {
            //Destroy(other.gameObject);
            _gameManager.ChangeLife(-1);
            if(_gameManager.life<0){
                Destroy(other.gameObject);
                SceneManager.LoadScene(sceneName);
            }
            Destroy(gameObject);
            
        }
    }
}
