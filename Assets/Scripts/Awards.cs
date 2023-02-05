using UnityEngine;

public class Awards : MonoBehaviour
{
    [SerializeField] private GameObject Panel_Awards;
    [SerializeField] private Animator Animator_Awards;
    [SerializeField] private SpriteRenderer Awards_Sprite;
    [SerializeField] private GameObject Click_Award1, Click_Award2, Click_Award3, Click_Award4;
    [SerializeField] private Sprite Clicks1, Clicks2, Clicks3, Clicks4;

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
            Animator_Awards.SetTrigger("AnimActive");
            Click_Award1.SetActive(true);
            Awards_Sprite.sprite = Clicks1;
        }
        if (Clicks == 100)
        {
            Animator_Awards.SetTrigger("AnimActive");
            Click_Award2.SetActive(true);
            Awards_Sprite.sprite = Clicks2;
        }
        if (Clicks == 1000)
        {
            Animator_Awards.SetTrigger("AnimActive");
            Click_Award3.SetActive(true);
            Awards_Sprite.sprite = Clicks3;
        }
        if (Clicks == 10000)
        {
            Animator_Awards.SetTrigger("AnimActive");
            Click_Award4.SetActive(true);
            Awards_Sprite.sprite = Clicks4;
        }
    }
}


