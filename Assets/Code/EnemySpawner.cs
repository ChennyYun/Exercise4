using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float time = 30f;
    public GameObject[] enemyPrefabs;
    // Start is called before the first frame update
    public int randIndex = 0;
    IEnumerator Start()
    {
        while (time > 20)
        {
            Vector2 spawnPos = new Vector2(Random.Range(10, 15), Random.Range(-5, 5));
            Instantiate(enemyPrefabs[randIndex], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
        while (time > 10 && time < 20)
        {
            Vector2 spawnPos = new Vector2(Random.Range(10, 15), Random.Range(-5, 5));
            Instantiate(enemyPrefabs[randIndex], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
        while (time < 10)
        {
            Vector2 spawnPos = new Vector2(Random.Range(10, 15), Random.Range(-5, 5));
            Instantiate(enemyPrefabs[randIndex], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update() {
        time -= Time.deltaTime;
        randIndex = Random.Range(0,enemyPrefabs.Length);
    }
}
