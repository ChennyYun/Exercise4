using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public float time = 60f;
    public GameObject laserPrefab;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (time > 40)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-10, 8), 0);
            Instantiate(laserPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
        while (time > 20 && time < 40)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-10, 8), 0);
            Instantiate(laserPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        while (time < 20)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-10, 8), 0);
            Instantiate(laserPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    void Update() {
        time -= Time.deltaTime;
    }
}
