using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int UIPanel;
    public int rations;
    public int morale;
    public int money;
    public int durability;
    public int ammo;
    public int maxAmmo;
    
    public PlayerData()
    {
        rations = 10;
        morale = 100;
        money = 20;
        durability = 5;
        ammo = 1;
        maxAmmo = 5;
    }
}
