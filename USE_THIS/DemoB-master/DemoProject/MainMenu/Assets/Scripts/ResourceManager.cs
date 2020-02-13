using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    [SerializeField] int rations = 10;
    [SerializeField] int morale = 5;
    [SerializeField] int money = 20;
    [SerializeField] int durability = 100;
    [SerializeField] int ammo = 1;
    [SerializeField] int maxAmmo = 5;

    public void SetRations(int value)
    {
        rations = value;
    }
    public void IncreaseRations(int changeAmt)
    {
        rations += changeAmt;
    }
    public void DecreaseRations(int changeAmt)
    {
        rations -= changeAmt;
    }

    public void SetMorale(int value)
    {
        morale = value;
    }
    public void IncreaseMorale(int changeAmt)
    {
        rations += changeAmt;
    }
    public void DecreaseMorale(int changeAmt)
    {
        rations -= changeAmt;
    }

    public void SetMoney(int value)
    {
        money = value;
    }
    public void IncreaseMoney(int changeAmt)
    {
        money += changeAmt;
    }
    public void DecreaseMoney(int changeAmt)
    {
        money -= changeAmt;
    }

    public void SetDurability(int value)
    {
        durability = value;
    }
    public void IncreaseDurability(int changeAmt)
    {
        durability += changeAmt;
    }
    public void DecreaseDurability(int changeAmt)
    {
        durability -= changeAmt;
    }

    public void SetAmmo(int value)
    {
        ammo = value;
    }
    public void IncreaseAmmo(int changeAmt)
    {
        ammo += changeAmt;
    }
    public void DecreaseAmmo(int changeAmt)
    {
        ammo -= changeAmt;
    }
}
