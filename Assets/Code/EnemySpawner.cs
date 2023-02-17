using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float time = 60f;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (time > 40)
        {
            Vector2 spawnPos = new Vector2(Random.Range(10, 15), Random.Range(-5, 5));
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
        while (time > 20 && time < 40)
        {
            Vector2 spawnPos = new Vector2(Random.Range(10, 15), Random.Range(-5, 5));
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
        while (time < 20)
        {
            Vector2 spawnPos = new Vector2(Random.Range(10, 15), Random.Range(-5, 5));
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update() {
        time -= Time.deltaTime;
    }
}
