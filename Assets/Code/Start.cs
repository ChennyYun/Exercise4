using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Suning Testing Collaborative Development
// Chenny Testing
// Kerwin Testing
public class Start : MonoBehaviour
{
    public string sceneName;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
