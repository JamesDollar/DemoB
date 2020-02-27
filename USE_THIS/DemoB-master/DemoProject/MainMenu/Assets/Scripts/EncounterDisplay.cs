using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncounterDisplay : MonoBehaviour
{
    [SerializeField] Encounter[] _encounters = new Encounter[0];
    public Encounter _encounter;

    public Text _titleText;
    public Text _descText;

    public Text _choice1Text;
    public Text _choice1CostText;

    public Text _choice2Text;
    public Text _choice2CostText;

    public Text RecapA;  //a
    public Text ArecapScreenText;//b
    public Text RecapB;  //a
    public Text _BrecapScreenText;//b

    //Resource
    public Text DuraText;
    //public Text DisplDuraText;
    public Text AmmoText;
    //public Text DispAmmoText;
    public Text RationsText;
    //public Text DispRationsText;
    public Text MoneyText;
    //public Text DispMoneyText;
    public Text MoraleText;
    //public Text DispMoraleText;


    void OnEnable()
    {
        SetEncounter(_encounters[GenerateEncounter(1, 12)]);//generates a random encounter and sets it
        _titleText.text = _encounter.Title;
        _descText.text = _encounter.Description;

        _choice1Text.text = _encounter.Choice1;
        _choice1CostText.text = _encounter.Choice1Cost;

        _choice2Text.text = _encounter.Choice2;
        _choice2CostText.text = _encounter.Choice2Cost;

        RecapA.text = _encounter.RecapA.ToString();//c
        RecapB.text = _encounter.RecapB.ToString();//c

        //DuraText.text = _encounter.DuraText.ToString();
        //AmmoText.text = _encounter.AmmoText.ToString();
        //RationsText.text = _encounter.RationsText.ToString();
        //MoneyText.text = _encounter.RationsText.ToString();
        //MoraleText.text = _encounter.MoraleText.ToString();
    }

    //sets the displayed encounter to the input encounter
    public void SetEncounter(Encounter newEncounter){
        Debug.Log("Setting new Encounter...");
        _encounter = newEncounter;
    }

    //generate a random number
    int GenerateEncounter(int min, int max)
    {
        Debug.Log("Generating number...");
        return Random.Range(min, max);
    }

}
