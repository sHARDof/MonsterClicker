using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource Music_Back;

    private float Music_Volume = 1f;

    private void Update()
    {
        Music_Back.volume = Music_Volume;
    }

    public void Set_Volume(float Volume_Slide)
    {
        Music_Volume = Volume_Slide;
    }
}
