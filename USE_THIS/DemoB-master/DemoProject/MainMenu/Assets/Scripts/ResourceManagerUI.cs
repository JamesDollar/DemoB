using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResourceManagerUI : MonoBehaviour
{
    [SerializeField] Text rationTxt;
    [SerializeField] Text moraleTxt;
    [SerializeField] Text moneyTxt;
    [SerializeField] Text durabilityTxt;
    [SerializeField] Text ammoTxt;

    [SerializeField] Color positiveColor;
    [SerializeField] Color negativeColor;
    [SerializeField] GameObject LoseStateRations;
    [SerializeField] GameObject moraleLState;
    [SerializeField] GameObject LStateBroke;
    [SerializeField] GameObject LStateDura;
    [SerializeField] GameObject EmptyAmmoClip;
    [SerializeField] GameObject WinState;
    [SerializeField] GameObject WinStateII;


    FloatingTextController floatingTextController;
    public bool firstMoney = false;
    
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

        if (rations <= 0)//LState
        {
            LoseStateRations.SetActive(true);
            //Reinit4();
        }
        //void Reinit4()
        //{
           // SceneManager.LoadScene("WorkingRecapScreen");
        //}
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
        if (morale <= 0)//LState
        {
            moraleLState.SetActive(true);
            //Reinit3();
        }
        //void Reinit3()
        //{
            //SceneManager.LoadScene("WorkingRecapScreen");
        ///}

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

       if (money <= 0)//LState
       {
            LStateBroke.SetActive(true);
            //Reinit2();
       }
        //void Reinit2()
        //{
        // SceneManager.LoadScene("WorkingRecapScreen");
        //}

        

        if (money >= 100  )
      {
            //firstMoney = (true);
            WinState.SetActive(true);
            //firstMoney = (false);
      }

     

      
     

      else
      {
            //f//irstMoney = (false);
           
            
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
        if (durability <= 0)
        {
            LStateDura.SetActive(true);
            //Reinit1();
        }
        //void Reinit1()
        //{
            //SceneManager.LoadScene("WorkingRecapScreen");
       // }

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

       if (ammo <= 0)
        {
            EmptyAmmoClip.SetActive(true);
            //Reinit();
        }

         //void Reinit()
        //{
            //SceneManager.LoadScene("WorkingRecapScreen");
       // }


    }

    

}
