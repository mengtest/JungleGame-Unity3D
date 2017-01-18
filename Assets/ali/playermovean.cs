using UnityEngine;
using System.Collections;



public class playermovean : MonoBehaviour {

    
    public float moveSpeed = 5.0f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25.0f;
    public ControllerJoystick moveJoystick;

    private Rigidbody controller;
    private Transform camTransform;

	// Use this for initialization
	private void Start () {
        controller = GetComponent<Rigidbody>();
        controller.maxAngularVelocity = terminalRotationSpeed;
        controller.drag = drag;

        camTransform = Camera.main.transform;
    }
	
	// Update is called once per frame
	   private void Update () {

        Vector3 dir = Vector3.zero;

        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        if (dir.magnitude > 1)
            dir.Normalize();

        Vector3 rotatDir = camTransform.TransformDirection(dir);

        if (moveJoystick.InputDirection!=Vector3.zero)
        {
            dir = moveJoystick.InputDirection; 
        }

        rotatDir = new Vector3( rotatDir.x , 0, rotatDir.z );
        rotatDir = rotatDir.normalized * dir.magnitude;

        controller.AddForce(rotatDir * moveSpeed);
	}
 
}
