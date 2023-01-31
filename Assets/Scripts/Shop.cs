using UnityEngine;

public class Shop : MonoBehaviour
{
    private int[] Costs = { 100, 500 };

    public void Upgrade1()
    {
        if (Player.Money >= Costs[0])
        {
            Player.Money -= Costs[0];
            Player.Damage_Player += 1;
        }
        else
        {
            return;
        }
    }

    public void Upgrade2()
    {
        if (Player.Money >= Costs[1])
        {
            Player.Money -= Costs[1];
            Player.Damage_Player += 2;
        }
        else
        {
            return;
        }
    }
}
