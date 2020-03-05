using UnityEngine;

public class input : MonoBehaviour
{
    //private LineRenderer lineRenderer;
    public GameObject thisthing;
    private float zOffset = 10;

    private void Awake()
    {
        //lineRenderer = GetComponent<LineRenderer>();
        swipe.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        //thisthing.SetActive(true);
        //thisthing.SetActive(false);
        bool IsActive = thisthing.activeSelf;
        thisthing.SetActive(!IsActive);
    }
}