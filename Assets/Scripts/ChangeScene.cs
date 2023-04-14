using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MainGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LearderBoard()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
    private void Update()
    {
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
