using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Text Money_Text;
    [SerializeField] Text Damage_Text;

    public static int Damage_Player = 1;
    public static int Money = 0;

    private void Update()
    {
        Money_Text.text = Money + "";
        Damage_Text.text = Damage_Player + "";
    }
}
