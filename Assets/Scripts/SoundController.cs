using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static float Sound_Volume = 1f;

    public void Set_Volume(float Volume_Slide)
    {
        Sound_Volume = Volume_Slide;
    }
}
