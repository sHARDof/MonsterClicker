using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public void Set_Volume(float Volume_Slide)
    {
        Sound.Sound_Volume = Volume_Slide;
    }
}
