using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] GameObject _rootPanel = null;
    [SerializeField] GameObject _two = null;
    [SerializeField] GameObject _ChoiceB = null;


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
            case MenuState.ChoiceA:
                _two.gameObject.SetActive(true);
                _rootPanel.gameObject.SetActive(false);

                break;
            case MenuState.ChoiceB:
                _ChoiceB.gameObject.SetActive(true);
                _rootPanel.gameObject.SetActive(false);
                _two.gameObject.SetActive(false);

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
