using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    [SerializeField] Text floatingText;

    void Awake()
    {
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(0, 0.5f, 0);
        transform.position = newPosition;
    }

    public void SetText(string txt)
    {
        floatingText.text = txt;
    }
}