using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public int startScene;
    public void StartGame(){
        SceneManager.LoadScene(startScene);
    }
}
