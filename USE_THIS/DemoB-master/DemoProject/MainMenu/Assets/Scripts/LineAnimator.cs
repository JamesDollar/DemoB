using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimator : MonoBehaviour
{
    [SerializeField] Transform _start;
    [SerializeField] Transform _end;
    [SerializeField] float _duration = .3f;

    void OnEnable()
    {
        StartCoroutine(LineMovement());
    }

    IEnumerator LineMovement()
    {
        Vector3 startPos = _start.position;
        Vector3 endPos = _end.position;
        // blink player process
        for (float t = 0; t < _duration; t += Time.deltaTime)  //while movement is less than total distance, keep animating
        {
            Vector3 newPosition = Vector3.Lerp(startPos, endPos, t / _duration);   //Find how much time has elapsed
            gameObject.transform.position = newPosition;//Move transform slightly towards end position
            yield return new WaitForFixedUpdate();  //leave coroutine, wait for FixedUpdate to catch up - This allows for animation and "movement"
        }
    }
}
