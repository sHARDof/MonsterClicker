using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Text Text_Hp;
    [SerializeField] private SpriteRenderer Enemy_SR;
    [SerializeField] private Sprite[] MonsterArr_sprites = { Monster0, Monster1, Monster2, Monster3, Monster4, Monster5};

    private static Sprite Monster1, Monster2, Monster3, Monster4, Monster5, Monster0;

    public static int[] HP = {1, 5, 15, 50, 150, 250 };
    private int[] HP_Copy = {1, 5, 15, 50, 150, 250 };

    private void OnMouseDown()
    {
        if (HP[Levels.Level] - Player.Damage_Player > 0)
        {
            HP[Levels.Level] -= Player.Damage_Player;
        }
        else
        {
            HP[Levels.Level] = HP_Copy[Levels.Level];
            Player.Money += 1;
        }
    }

    private void Update()
    {
        Enemy_SR.sprite = MonsterArr_sprites[Levels.Level];
        Text_Hp.text = HP[Levels.Level] + " HP";

        if (HP[Levels.Level] == 0)
        {
            Player.Money += 1;
            HP[Levels.Level] = HP_Copy[Levels.Level];
        }
    }
}
