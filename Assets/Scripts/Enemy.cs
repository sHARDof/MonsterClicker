using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Text Text_Hp;
    [SerializeField] private ParticleSystem Enemy_Damge_PS;
    [SerializeField] private SpriteRenderer Enemy_SR;
    [SerializeField] private Sprite[] MonsterArr_sprites = { Monster0, Monster1, Monster2, Monster3, Monster4, Monster5 };

    [SerializeField] private GameObject SoundPrefab;

    private static Sprite Monster1, Monster2, Monster3, Monster4, Monster5, Monster0;
    
    private Sound Sound;

    public static int[] HP = {1, 5, 15, 50, 150, 250 };
    private int[] HP_Copy = {1, 5, 15, 50, 150, 250 };

    private void Start()
    {
        Sound = SoundPrefab.GetComponent<Sound>();
    }
    private void OnMouseDown()
    {
        Awards.Clicks += 1;
        Instantiate(Enemy_Damge_PS, transform.position, Quaternion.identity);
        Sound.ClickEnemy();
        Enemy_Damge();
    }
    private void Update()
    {
        Update_Sprite_Monster();
        Update_Text_Hp();
        Enemy_Death();
    }

    private void Enemy_Damge()
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
    private void Enemy_Death()
    {
        if (HP[Levels.Level] == 0)
        {
            Player.Money += 1;
            HP[Levels.Level] = HP_Copy[Levels.Level];
        }
    }
    private void Update_Text_Hp()
    {
        Text_Hp.text = HP[Levels.Level] + " HP";
    }
    private void Update_Sprite_Monster()
    {
        Enemy_SR.sprite = MonsterArr_sprites[Levels.Level];
    }
}
