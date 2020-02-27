using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour
{
    [SerializeField] GameObject floatingTextPrefab;
    Canvas canvas;

    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    public void CreateFloatingText(string text, Transform location)
    {
        GameObject floatingTxt = Instantiate(floatingTextPrefab);

        floatingTxt.transform.SetParent(canvas.transform);
        floatingTxt.transform.position = location.position;
        floatingTxt.GetComponent<FloatingText>().SetText(text);
    }
}