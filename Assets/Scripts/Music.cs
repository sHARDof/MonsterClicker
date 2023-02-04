using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource Music_Back;
    [SerializeField] Slider Music_Slider;

    public static float Music_Volume = 0.5f;

    private void Start()
    {
        Music_Back.playOnAwake = true;
        Music_Slider.value = Music_Volume;
    }

    private void Update()
    {
        Music_Back.volume = Music_Volume;
    }
}
