using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioSource Enemy_Click_sound;

    private void Update()
    {
        Enemy_Click_sound.volume = SoundController.Sound_Volume;
    }
}
