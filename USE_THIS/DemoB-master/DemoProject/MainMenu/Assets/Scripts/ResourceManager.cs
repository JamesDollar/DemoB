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

    [SerializeField] ResourceManagerUI resourceManagerUI;

    void Start()
    {
        SetRations(rations);
        SetMorale(morale);
        SetMoney(money);
        SetDurability(durability);
        SetAmmo(ammo);
    }

    public void SetRations(int value)
    {
        rations = value;
        resourceManagerUI.UpdateRations(rations);
    }
    public void IncreaseRations(int changeAmt)
    {
        SetRations(rations + changeAmt);

    }
    public void DecreaseRations(int changeAmt)
    {
        SetRations(rations - changeAmt);
    }

    public void SetMorale(int value)
    {
        morale = value;
        resourceManagerUI.UpdateMorale(morale);
    }
    public void IncreaseMorale(int changeAmt)
    {
        SetMorale(morale + changeAmt);
    }
    public void DecreaseMorale(int changeAmt)
    {
        SetMorale(morale - changeAmt);
    }

    public void SetMoney(int value)
    {
        money = value;
        resourceManagerUI.UpdateMoney(value);
    }
    public void IncreaseMoney(int changeAmt)
    {
        SetMoney(money + changeAmt);
    }
    public void DecreaseMoney(int changeAmt)
    {
        SetMoney(money - changeAmt);
    }

    public void SetDurability(int value)
    {
        durability = value;
        resourceManagerUI.UpdateDurability(value);
    }
    public void IncreaseDurability(int changeAmt)
    {
        SetDurability(durability + changeAmt);
    }
    public void DecreaseDurability(int changeAmt)
    {
        SetDurability(durability - changeAmt);
    }

    public void SetAmmo(int value)
    {
        ammo = Mathf.Clamp(value, 0, maxAmmo);
        resourceManagerUI.UpdateAmmo(ammo, maxAmmo);
    }
    public void IncreaseAmmo(int changeAmt)
    {
        SetAmmo(ammo + changeAmt);
    }
    public void DecreaseAmmo(int changeAmt)
    {
        SetAmmo(ammo - changeAmt);
    }

    public void UpdateResources(string type, int amount)
    {
        type = type.ToLower(); //sets string to all lowercase
        switch (type) { //searches for type of resource being changed, and then changes it
            case "money":
                IncreaseMoney(amount);
                Debug.Log("Money is now " + money);
                break;
            case "morale":
                IncreaseMorale(amount);
                Debug.Log("Morale is now " + morale);
                break;
            case "rations":
                IncreaseRations(amount);
                Debug.Log("Rations are now " + rations);
                break;
            case "ammo":
                IncreaseAmmo(amount);
                Debug.Log("Ammo is now " + ammo);
                break;
            case "durability":
                IncreaseDurability(amount);
                Debug.Log("Durability is now " + durability);
                break;
            
        }
    }
}
