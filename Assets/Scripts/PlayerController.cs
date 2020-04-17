using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour
{

    Rigidbody myRigidBody;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start() {
        myRigidBody = GetComponent<Rigidbody> ();
    }

    public void Move (Vector3 passedVelocity) {
        velocity = passedVelocity;
    }

    public void LookAt(Vector3 point) {
        Vector3 heightCorrection = new Vector3(point.x, transform.position.y, point.z);
        transform.LookAt(heightCorrection);
    }

    public void FixedUpdate () {
        myRigidBody.MovePosition(myRigidBody.position + velocity * Time.fixedDeltaTime);
    }


}
