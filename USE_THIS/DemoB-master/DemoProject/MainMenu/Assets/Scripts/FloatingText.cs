using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    [SerializeField] Text floatingText;
    [SerializeField] float floatSpeed = 1f;
    [SerializeField] float duration = 1.5f;

    [HideInInspector] public Color color;

    void Awake()
    {
        Destroy(gameObject, duration);
    }

    private void Update()
    {
        floatingText.color = color;
        Vector3 newPosition = transform.position + new Vector3(0, floatSpeed, 0);
        transform.position = newPosition;
    }

    public void SetText(string txt)
    {
        floatingText.text = txt;
    }
}