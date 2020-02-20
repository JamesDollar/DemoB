using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManagerUI : MonoBehaviour
{
    [SerializeField] Text rationTxt;
    [SerializeField] Text moraleTxt;
    [SerializeField] Text moneyTxt;
    [SerializeField] Text durabilityTxt;
    [SerializeField] Text ammoTxt;

    public void UpdateRations(int rations)
    {
        rationTxt.text = "" + rations;
    }

    public void UpdateMorale(int morale)
    {
        moraleTxt.text = "" + morale;
    }

    public void UpdateMoney(int money)
    {
        moneyTxt.text = "$" + money;
    }

    public void UpdateDurability(int durability)
    {
        durabilityTxt.text = "" + durability;
    }

    public void UpdateAmmo(int ammo, int maxAmmo)
    {
        ammoTxt.text = "" + ammo + " / " + maxAmmo;
    }
}
