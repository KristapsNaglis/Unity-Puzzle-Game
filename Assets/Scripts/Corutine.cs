using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutine : MonoBehaviour
{
    public Transform targetMid;
    public Transform targetFinal;
    public float smoothing;
    Vector3 startingPosition;
    Vector3 targetMidPosition;
    Vector3 targetFinalPosition;
   float timer;

   void Start()
   {
        startingPosition = transform.position;
        targetMidPosition = targetMid.position;
        targetFinalPosition = targetFinal.position;
        timer = 0.0f;
        StartCoroutine(MoveGameText(targetMidPosition, targetFinalPosition));
   }
   
    IEnumerator MoveGameText(Vector3 midTarget, Vector3 finalTarget)
    {


        while (transform.position != targetMidPosition) 
        {
            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(startingPosition, targetMidPosition, smoothing * Time.deltaTime);
        }

        yield return new WaitForSeconds(3f);

        timer += Time.deltaTime;
         transform.position = Vector3.Lerp(startingPosition, targetFinalPosition, smoothing * Time.deltaTime);
    }
}
