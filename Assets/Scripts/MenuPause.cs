using UnityEngine;

public class MenuPause : MonoBehaviour
{
    [SerializeField] GameObject Panel_Pause;

    public void OpenPauseMenu()
    {
        Panel_Pause.SetActive(true);
    }

    public void ClosePauseMenu()
    {
        Panel_Pause.SetActive(false);
    }
}
