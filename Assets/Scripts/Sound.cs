using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource Enemy_Click_AS;
    [SerializeField] private AudioSource Achievement_AS;
    [SerializeField] private Slider Sound_Slider;

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

    public void Achievement()
    {
        Achievement_AS.Play();
    }
}
