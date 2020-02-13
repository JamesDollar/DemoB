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
    public string Choice1Type;
    public int Choice1Amount;

    public string Choice2;
    public string Choice2Cost;
    public string Choice2Type;
    public int Choice2Amount;

    public void Print()
    {
        Debug.Log(Title);
        Debug.Log(Description);
    }
}
