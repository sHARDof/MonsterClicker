using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awards : MonoBehaviour
{
    [SerializeField] private GameObject Panel_Awards;
    [SerializeField] private SpriteRenderer Awards_Anim_Sprite;
    [SerializeField] private Animator Animator_Awards;
    [SerializeField] private GameObject Click_Award;
    [SerializeField] private Sprite[] Awards_sprites = { Clicks_Sprite };

    private static Sprite Clicks_Sprite;
    public static int Clicks = 0;

    private void Update()
    {
        Assigned_Award();
    }

    public void Open_Panel_Awards()
    {
        Panel_Awards.SetActive(true);
    }
    public void Close_Panel_Awards()
    {
        Panel_Awards.SetActive(false);
    }   
    public void Assigned_Award()
    {
        if (Clicks == 10)
        {
            Awards_Anim_Sprite.sprite = Awards_sprites[0];
            Animator_Awards.SetInteger("IndexAwards", 1);
            Click_Award.SetActive(true);
        }
    }
}
