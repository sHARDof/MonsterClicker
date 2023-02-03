using UnityEngine;

public class Shop : MonoBehaviour
{
    private int[] Costs = { 25, 100, 500, 1000, 1500};

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

    public void Upgrade3()
    {
        if (Player.Money >= Costs[2])
        {
            Player.Money -= Costs[2];
            Player.Damage_Player += 5;
        }
        else
        {
            return;
        }
    }

    public void Upgrade4()
    {
        if (Player.Money >= Costs[3])
        {
            Player.Money -= Costs[3];
            Player.Damage_Player += 10;
        }
        else
        {
            return;
        }
    }

    public void Upgrade5()
    {
        if (Player.Money >= Costs[4])
        {
            Player.Money -= Costs[4];
            Player.Damage_Player += 15;
        }
        else
        {
            return;
        }
    }
}
