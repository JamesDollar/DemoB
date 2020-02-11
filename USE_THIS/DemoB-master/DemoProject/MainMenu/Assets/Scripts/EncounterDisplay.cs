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

    public Text _choice3Text;
    public Text _choice3CostText;

    public Text _choice4Text;
    public Text _choice4CostText;

    // Start is called before the first frame update
    void Start()
    {
        _titleText.text = _encounter.Title;
        _descText.text = _encounter.Description;

        _choice1Text.text = _encounter.Choice1;
        _choice1CostText.text = _encounter.Choice1Cost;

        _choice2Text.text = _encounter.Choice2;
        _choice2CostText.text = _encounter.Choice2Cost;

        _choice3Text.text = _encounter.Choice3;
        _choice3CostText.text = _encounter.Choice3Cost;

        _choice4Text.text = _encounter.Choice4;
        _choice4CostText.text = _encounter.Choice4Cost;
}

}
