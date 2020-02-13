using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncounterDisplay : MonoBehaviour
{
    public Encounter _encounter;

    public Text _titleText;
    public Text _descText;

    public Text _choice1Text;
    public Text _choice1CostText;

    public Text _choice2Text;
    public Text _choice2CostText;

    // Start is called before the first frame update
    void Start()
    {
        _titleText.text = _encounter.Title;
        _descText.text = _encounter.Description;

        _choice1Text.text = _encounter.Choice1;
        _choice1CostText.text = _encounter.Choice1Cost;

        _choice2Text.text = _encounter.Choice2;
        _choice2CostText.text = _encounter.Choice2Cost;
    }

}
