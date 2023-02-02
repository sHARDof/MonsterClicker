using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource Music_Back;

    public static float Music_Volume = 0.5f;

    private void Start()
    {
        Music_Back.playOnAwake = true;
    }

    private void Update()
    {
        Music_Back.volume = Music_Volume;
    }
}
