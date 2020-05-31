using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public float cameraX = 0;
    public float cameraY = 0;
    public float cameraZ = 0;

    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(target.position.x + cameraX, target.position.y + cameraY, target.position.z + cameraZ); 
    }
}
