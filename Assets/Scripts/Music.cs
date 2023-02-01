using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource Music_Back;

    private void Update()
    {
        Music_Back.volume = MusicController.Music_Volume;
    }

    private void Start()
    {
        Music_Back.playOnAwake = true;
    }
}
