using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    public string sceneName;
    public Sprite Fire;
    public float lifeTime = 2;
    private float timer = 0f;
    public AudioSource source;
    public AudioClip clip;
    private bool played = false;


    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if(timer > 1) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Fire;
            if(!played){
                source.PlayOneShot(clip);
                played = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(timer > 1 && other.CompareTag("Player")) {
            Destroy(other.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(sceneName);
        }
    }
}
