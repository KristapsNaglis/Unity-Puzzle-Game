using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerController))]
public class Player : MonoBehaviour
{
    public Animator animator;
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
            //Debug.DrawLine(ray.origin, point, Color.red);
            playerController.LookAt(point);
            
            // "-1" is for inverting controls
            Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal") * (-1), 0, Input.GetAxisRaw("Vertical") * (-1));
            Vector3 localInput = transform.rotation * moveInput;
            Vector3 moveVelocity = localInput.normalized * moveSpeed;

            animator.SetFloat("vertical", Input.GetAxis("Vertical"));

            playerController.Move(moveVelocity);
        }
    }
}
