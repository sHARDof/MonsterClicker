using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject Settings_Panel;

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

    public void OpenSettings()
    {
        Settings_Panel.SetActive(true);
    }

    public void CloseSettings()
    {
        Settings_Panel.SetActive(false);
    }
}
