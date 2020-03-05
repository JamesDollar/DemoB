using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainMenuController : MonoBehaviour
{
    public MenuState State { get; private set; } = MenuState.None;
    public static event Action<MenuState> StateChanged = delegate { };


   

    void Start()
    {
        ChangeState(1);// call root state (1)

    }


    public void ChangeState(int stateIndex)
    {
        // convert index to state type 1= root, 2,3,etc
        State = (MenuState) stateIndex;
        StateChanged.Invoke(State);
    }
    public static event Action<string> MissionChanged = delegate { };
    public string ActiveMission { get; private set; } = "....";

    public void ChangeMission(string missionName)
    {
        ActiveMission = missionName;
        MissionChanged.Invoke(ActiveMission);
    }
}
