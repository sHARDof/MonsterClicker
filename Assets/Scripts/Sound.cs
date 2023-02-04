using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioSource Enemy_Click_AS;
    [SerializeField] Slider Sound_Slider;

    public static float Sound_Volume = 0.5f;

    private void Update()
    {
        Enemy_Click_AS.volume = Sound_Volume;
        Sound_Slider.value = Sound_Volume;
    }

    public void ClickEnemy()
    {
        Enemy_Click_AS.Play();
    }
}
