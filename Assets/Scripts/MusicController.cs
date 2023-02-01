using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static float Music_Volume = 1f;

    public void Set_Volume(float Volume_Slide)
    {
        Music_Volume = Volume_Slide;
    }
}
