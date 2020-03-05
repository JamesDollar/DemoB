using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneResetter : MonoBehaviour
{
    void Start()
    {
        void Reinit()
        {
            SceneManager.LoadScene("WorkingRecapScreen");
        }



    }
}
