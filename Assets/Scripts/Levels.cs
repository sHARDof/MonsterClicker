using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{    
    [SerializeField] private Text Level_Text;

    public static int Level = 1;

    public void Click_Button_Next()
    {
        if (Level > Enemy.HP.Length - 2)
        {
            return;
        }
        else
        {
            Level++;
        }
    }

    public void Click_Button_Back()
    {
        if (Level > 1)
        {
            Level--;
        }
        else
        {
            return;
        }
    }

    private void Update()
    {
        Level_Text.text = "Level: " + Level;
    }
}
