using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Encounter", menuName = "Encounter")]
public class Encounter : ScriptableObject
{
    public string Title;
    [TextArea]
    public string Description;

    public string Choice1;
    public string Choice1Cost;

    public string Choice2;
    public string Choice2Cost;

    public string Choice3;
    public string Choice3Cost;

    public string Choice4;
    public string Choice4Cost;

    public void Print()
    {
        Debug.Log(Title);
        Debug.Log(Description);
    }
}
