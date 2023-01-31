using UnityEngine;

public class MenuPause : MonoBehaviour
{
    [SerializeField] GameObject Panel_Pause;

    public void Open_Pause_Menu()
    {
        Panel_Pause.SetActive(true);
    }

    public void Close_Pause_Menu()
    {
        Panel_Pause.SetActive(false);
    }
}
