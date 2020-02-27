using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextController : MonoBehaviour
{
    [SerializeField] GameObject floatingTextPrefab;
    Canvas canvas;

    [HideInInspector] public Color color;

    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    public void CreateFloatingText(string text, Transform location)
    {
        GameObject floatingTxt = Instantiate(floatingTextPrefab);

        floatingTxt.GetComponent<FloatingText>().color = color;

        floatingTxt.transform.SetParent(canvas.transform);
        floatingTxt.transform.position = location.position + new Vector3(0, 40f, 0);
        floatingTxt.GetComponent<FloatingText>().SetText(text);
    }
}