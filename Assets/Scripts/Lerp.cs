using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour {

    public Transform target;
    public float travelTime;

    Vector3 startingPosition;
    Vector3 targetPosition;


    float timer;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        targetPosition = target.position;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(startingPosition, targetPosition, timer/travelTime);
    }
}
