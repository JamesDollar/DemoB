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

    void OnEnable()
    {
        SetEncounter(_encounters[GenerateEncounter(1, 12)]);//generates a random encounter and sets it
        //fills in scriptable object
        _titleText.text = _encounter.Title;
        _descText.text = _encounter.Description;

        _choice1Text.text = _encounter.Choice1;
        _choice1CostText.text = _encounter.Choice1Cost;

        _choice2Text.text = _encounter.Choice2;
        _choice2CostText.text = _encounter.Choice2Cost;
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
