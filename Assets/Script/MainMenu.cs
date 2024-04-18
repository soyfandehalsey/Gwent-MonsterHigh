using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ActionEvent(string nameMethod)
    {
        Invoke(nameMethod, 0.2f);
    }
    private void GoPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void Out()
    {
        Application.Quit();
    }
}

//public GameObject musicManager;
//musicManager.GetComponent<AudioSource>().Play();