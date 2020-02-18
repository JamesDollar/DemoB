﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterResourceInterface : MonoBehaviour
{
    [SerializeField] GameObject _encounterInfo = null;
    Encounter _encounter;
    ResourceManager _resourceManager;

    string Choice1Type;
    int Choice1Amount;
    string Choice2Type;
    int Choice2Amount;

    void Start()
    {
        _resourceManager = gameObject.GetComponent<ResourceManager>();
        _encounter = _encounterInfo.GetComponent<EncounterDisplay>()._encounter;
    }

    public void Choice1()
    {
        Debug.Log("choice 1 selected");
        //pulls type and amount from encounter choice 1
        Choice1Type = _encounter.Choice1Type;
        Choice1Amount = _encounter.Choice1Amount;
        //feeds info to ResourceManager and updates resource amounts
        Debug.Log("Interfacing resources(Choice1)...");
        _resourceManager.UpdateResources(Choice1Type, Choice1Amount);
    }

    public void Choice2()
    {
        Debug.Log("choice 2 selected");
        //pulls type and amount from encounter choice 2
        Choice2Type = _encounter.Choice2Type;
        Choice2Amount = _encounter.Choice2Amount;
        //feeds info to ResourceManager and updates resource amounts
        Debug.Log("Interfacing resources(Choice2)...");
        _resourceManager.UpdateResources(Choice2Type, Choice2Amount);
    }
}