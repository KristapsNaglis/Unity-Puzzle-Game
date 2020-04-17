using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerController))]
public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public Camera camera;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        playerController = GetComponent<PlayerController> ();
    }

    // Update is called once per frame
    void Update() {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance)) {
            Vector3 point = ray.GetPoint(rayDistance);
            // Debug.DrawLine(ray.origin, point, Color.red);
            playerController.LookAt(point);
            
            Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            Vector3 localInput = transform.rotation * moveInput;
            Vector3 moveVelocity = localInput.normalized * moveSpeed;
            playerController.Move(moveVelocity);
        }
    }
}
