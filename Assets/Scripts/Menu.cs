using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play_Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit_Game()
    {
        Application.Quit();
    }

    public void Open_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
