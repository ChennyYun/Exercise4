using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int speed = 10;
    int bulletSpeed = 400;
    public Transform spawnPoint;
    public AudioClip shootSound;

    public GameObject bulletPrefab;
    Rigidbody2D _rigidbody2D;
    AudioSource _audioSource;

    bool isMilk = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        float ySpeed = Input.GetAxis("Vertical") * speed;
        _rigidbody2D.velocity = new Vector2(xSpeed, ySpeed);

        if(Input.GetButtonDown("Jump")) {
            _audioSource.PlayOneShot(shootSound);
            GameObject newBullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0));
            if (isMilk) {
                GameObject newBullet2 = Instantiate(bulletPrefab, spawnPoint.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
                newBullet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0));
                GameObject newBullet3 = Instantiate(bulletPrefab, spawnPoint.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
                newBullet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0));
            }
        }
    }

       private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Boots")) {
            speed = 20;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Milk")) {
            isMilk = true;
            Destroy(other.gameObject);
        }
    }
}
