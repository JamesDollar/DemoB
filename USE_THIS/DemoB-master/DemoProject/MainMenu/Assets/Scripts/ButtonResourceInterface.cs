using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonResourceInterface : MonoBehaviour
{
    [SerializeField] GameObject _resourceManagerContainer;
    [SerializeField] EncounterDisplay _encounterDisplay;
    ResourceManager _resourceManager;
    Encounter _encounter;

    [SerializeField] public Button _button1;
    [SerializeField] public Button _button2;
    [SerializeField] public Text _button1Text;
    [SerializeField] public Text _button2Text;

    string _choice1Type;
    int _choice1Amount;
    string _choice2Type;
    int _choice2Amount;

    void OnEnable()
    {
        _encounter = _encounterDisplay.GetComponent<EncounterDisplay>()._encounter;
        _resourceManager = _resourceManagerContainer.GetComponent<ResourceManager>();
        FillData();
        CompareResources();
    }
    void Update()
    {
        _encounter = _encounterDisplay.GetComponent<EncounterDisplay>()._encounter;
        _resourceManager = _resourceManagerContainer.GetComponent<ResourceManager>();
    }

    void CompareResources()
    {
        Debug.Log("Checking for Sufficient Resources");
        _choice1Type.ToLower();
        _choice2Type.ToLower();
        switch (_choice1Type)
        {
            case "money":
                if(_choice1Amount < 0 && _resourceManager.money < Mathf.Abs(_choice1Amount))
                {
                    _button1.gameObject.SetActive(false);
                    _button1Text.gameObject.SetActive(false);
                }
                break;
            case "morale":
                if (_choice1Amount < 0 && _resourceManager.morale < Mathf.Abs(_choice1Amount))
                {
                    _button1.gameObject.SetActive(false);
                    _button1Text.gameObject.SetActive(false);
                }
                break;
            case "rations":
                if (_choice1Amount < 0 && _resourceManager.rations < Mathf.Abs(_choice1Amount))
                {
                    _button1.gameObject.SetActive(false);
                    _button1Text.gameObject.SetActive(false);
                }
                break;
            case "ammo":
                if (_choice1Amount < 0 && _resourceManager.ammo < Mathf.Abs(_choice1Amount))
                {
                    _button1.gameObject.SetActive(false);
                    _button1Text.gameObject.SetActive(false);
                }
                break;
            case "durability":
                if (_choice1Amount < 0 && _resourceManager.durability < Mathf.Abs(_choice1Amount))
                {
                    _button1.gameObject.SetActive(false);
                    _button1Text.gameObject.SetActive(false);
                }
                break;
        }
        switch (_choice2Type)
        {
            case "money":
                if (_choice2Amount < 0 && _resourceManager.money < Mathf.Abs(_choice2Amount))
                {
                    _button2.enabled = false;
                    _button2Text.enabled = false;
                }
                break;
            case "morale":
                if (_choice2Amount < 0 && _resourceManager.morale < Mathf.Abs(_choice2Amount))
                {
                    _button2.enabled = false;
                    _button2Text.enabled = false;
                }
                break;
            case "rations":
                if (_choice2Amount < 0 && _resourceManager.rations < Mathf.Abs(_choice2Amount))
                {
                    _button2.enabled = false;
                    _button2Text.enabled = false;
                }
                break;
            case "ammo":
                if (_choice2Amount < 0 && _resourceManager.ammo < Mathf.Abs(_choice2Amount))
                {
                    _button2.enabled = false;
                    _button2Text.enabled = false;
                }
                break;
            case "durability":
                if (_choice2Amount < 0 && _resourceManager.durability < Mathf.Abs(_choice2Amount))
                {
                    _button2.enabled = false;
                    _button2Text.enabled = false;
                }
                break;
        }
    }

    void FillData()
    {
        Debug.Log("Filling Data...");
        _choice1Type = _encounter.Choice1Type;
        _choice1Amount = _encounter.Choice1Amount;
        _choice2Type = _encounter.Choice2Type;
        _choice2Amount = _encounter.Choice2Amount;
    }
}
