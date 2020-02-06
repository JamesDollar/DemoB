using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] GameObject _rootPanel = null;
    [SerializeField] GameObject _AnimationPanel = null;
    [SerializeField] GameObject _ProblemChoices = null;
    [SerializeField] GameObject _ChoicesScreen = null;
    [SerializeField] GameObject _DaysRecap = null;
    [SerializeField] GameObject _AnimationPanelD2 = null;
    [SerializeField] GameObject _ProblemChoicesD2 = null;
    [SerializeField] GameObject _ChoicesD2 = null;
    [SerializeField] GameObject _DaysRecapD2 = null;
    [SerializeField] GameObject _AnimationPanelD3 = null;
    [SerializeField] GameObject _ProblemChoicesD3 = null;
    [SerializeField] GameObject _ChoicesD3 = null;
    [SerializeField] GameObject _RecapD3 = null;
    [SerializeField] GameObject _AnimationPanelD4 = null;
    [SerializeField] GameObject _ProblemChoicesD4 = null;
    [SerializeField] GameObject _ChoicesD4 = null;
    [SerializeField] GameObject _RecapD4 = null;
    [SerializeField] GameObject _RecapD41 = null;
    [SerializeField] GameObject _falls7 = null;
    [SerializeField] GameObject _falls8 = null;
    [SerializeField] GameObject _falls9 = null;
    [SerializeField] GameObject _rootPanel1 = null;
    [SerializeField] GameObject _rootPanel2 = null;
    void OnEnable()
    {
        MainMenuController.StateChanged += OnStateChanged;

    }

    void OnDisable()
    {
        MainMenuController.StateChanged -= OnStateChanged;
    }

    void OnStateChanged(MenuState newState)
    {
        DisablePanels();

        switch (newState)
        {
            case MenuState.Root:
                _rootPanel.gameObject.SetActive(true);

                break;
            case MenuState.AnimationPanel: 
             _AnimationPanel.gameObject.SetActive(true);
                _rootPanel.gameObject.SetActive(false);
                

                break;
            case MenuState.ProblemChoices:
                _ProblemChoices.SetActive(true);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);

                break;

            case MenuState.ChoicesScreen:
                _ChoicesScreen.SetActive(true);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.DaysRecap:
                _DaysRecap.SetActive(true);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.AnimationPanelD2:
                _AnimationPanelD2.SetActive(true);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.ProblemChoicesD2:
                _ProblemChoicesD2.SetActive(true);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.ChoicesD2:
                _ChoicesD2.SetActive(true);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.DaysRecapD2:
                _DaysRecapD2.SetActive(true);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;

            case MenuState.AnimationPanelD3:
                _AnimationPanelD3.SetActive(true);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.ProbChoicesD3:
                _ProblemChoicesD3.SetActive(true);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.ChoicesD3:
                _ChoicesD3.SetActive(true);
                _ProblemChoicesD3.SetActive(false);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.RecapD3:
                _RecapD3.SetActive(true);
                _ChoicesD3.SetActive(false);
                _ProblemChoicesD3.SetActive(false);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.AnimationPanelD4:
                _AnimationPanelD4.SetActive(true);
                _RecapD3.SetActive(false);
                _ChoicesD3.SetActive(false);
                _ProblemChoicesD3.SetActive(false);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.ProbChoicesD4:
                _ProblemChoicesD4.SetActive(true);
                _AnimationPanelD4.SetActive(false);
                _RecapD4.SetActive(false);
                _ChoicesD3.SetActive(false);
                _ProblemChoicesD3.SetActive(false);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.ChoicesD4:
                _ChoicesD4.SetActive(true);
                _ProblemChoicesD4.SetActive(false);
                _AnimationPanelD4.SetActive(false);
                _RecapD4.SetActive(false);
                _ChoicesD3.SetActive(false);
                _ProblemChoicesD3.SetActive(false);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
            case MenuState.DaysRecapD4:
                _RecapD4.SetActive(true);
                _ChoicesD4.SetActive(false);
                _ProblemChoicesD4.SetActive(false);
                _AnimationPanelD4.SetActive(false);
               // _RecapD4.SetActive(false);
                _ChoicesD3.SetActive(false);
                _ProblemChoicesD3.SetActive(false);
                _AnimationPanelD3.SetActive(false);
                _DaysRecapD2.SetActive(false);
                _ChoicesD2.SetActive(false);
                _ProblemChoicesD2.SetActive(false);
                _AnimationPanelD2.SetActive(false);
                _DaysRecap.SetActive(false);
                _ChoicesScreen.SetActive(false);
                _AnimationPanel.gameObject.SetActive(false);
                _rootPanel.gameObject.SetActive(false);
                _ProblemChoices.SetActive(false);
                break;
                //case MenuState.MissionConfirm8:
                //_missionConfirmPanel8.gameObject.SetActive(true);
                //_dumbass.gameObject.SetActive(true);
                //_falls8.gameObject.SetActive(true);
                //SceneManager.LoadScene(1);
                // break;
                //case MenuState.MissionConfirm9:
                //_missionConfirmPanel8.gameObject.SetActive(true);
                //_dumbass.gameObject.SetActive(true);
                //_falls8.gameObject.SetActive(true);
                // SceneManager.LoadScene(0);
                // break;
                // case MenuState.MissionConfirm10:
                //_missionConfirmPanel8.gameObject.SetActive(true);
                //_dumbass.gameObject.SetActive(true);
                //_falls8.gameObject.SetActive(true);
                //Application.Quit();
                // break;

                //default:
                //Debug.Log("State not valid");
                // break;


        }
    }
  private void DisablePanels()
    {
       // _rootPanel.gameObject.SetActive(false);
       // _missionSelectPanel.gameObject.SetActive(false);
    }
}
