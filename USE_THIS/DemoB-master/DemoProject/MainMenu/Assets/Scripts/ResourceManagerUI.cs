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

    [SerializeField] Color positiveColor;
    [SerializeField] Color negativeColor;

    FloatingTextController floatingTextController;

    void Awake()
    {
        floatingTextController = GameObject.Find("FloatingTextController").GetComponent<FloatingTextController>();
    }

    public void UpdateRations(int rations, int changeAmt)
    {
        rationTxt.text = "" + rations;

        if (changeAmt > 0)
        {
            floatingTextController.color = positiveColor;
            floatingTextController.CreateFloatingText("+" + changeAmt, rationTxt.rectTransform);
        }
        else if (changeAmt < 0)
        {
            floatingTextController.color = negativeColor;
            floatingTextController.CreateFloatingText("" + changeAmt, rationTxt.rectTransform);
        }
    }

    public void UpdateMorale(int morale, int changeAmt)
    {
        moraleTxt.text = "" + morale;

        if (changeAmt > 0)
        {
            floatingTextController.color = positiveColor;
            floatingTextController.CreateFloatingText("+" + changeAmt, moraleTxt.rectTransform);
        }
        else if (changeAmt < 0)
        {
            floatingTextController.color = negativeColor;
            floatingTextController.CreateFloatingText("" + changeAmt, moraleTxt.rectTransform);
        }
    }

    public void UpdateMoney(int money, int changeAmt)
    {
        moneyTxt.text = "$" + money;

        if (changeAmt > 0)
        {
            floatingTextController.color = positiveColor;
            floatingTextController.CreateFloatingText("+" + changeAmt, moneyTxt.rectTransform);
        }
        else if (changeAmt < 0)
        {
            floatingTextController.color = negativeColor;
            floatingTextController.CreateFloatingText("" + changeAmt, moneyTxt.rectTransform);
        }
    }

    public void UpdateDurability(int durability, int changeAmt)
    {
        durabilityTxt.text = "" + durability;

        if (changeAmt > 0)
        {
            floatingTextController.color = positiveColor;
            floatingTextController.CreateFloatingText("+" + changeAmt, durabilityTxt.rectTransform);
        }
        else if (changeAmt < 0)
        {
            floatingTextController.color = negativeColor;
            floatingTextController.CreateFloatingText("" + changeAmt, durabilityTxt.rectTransform);
        }
    }

    public void UpdateAmmo(int ammo, int maxAmmo, int changeAmt)
    {
        ammoTxt.text = "" + ammo + " / " + maxAmmo;

        if (changeAmt > 0)
        {
            floatingTextController.color = positiveColor;
            floatingTextController.CreateFloatingText("+" + changeAmt, ammoTxt.rectTransform);
        }
        else if (changeAmt < 0)
        {
            floatingTextController.color = negativeColor;
            floatingTextController.CreateFloatingText("" + changeAmt, ammoTxt.rectTransform);
        }
    }
}
