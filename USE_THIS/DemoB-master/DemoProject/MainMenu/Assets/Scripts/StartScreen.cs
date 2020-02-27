using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    [SerializeField] GameObject StartScreen1;
    
    // Start is called before the first frame update
   public void CloseIt()
    {
        bool IsActive = StartScreen1.activeSelf;
        StartScreen1.SetActive(!IsActive);
    }
}
