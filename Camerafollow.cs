using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour {

    public Transform Target;
    public Vector3 Offset;//(0, 8, -12)
    public float Rotation;//11
    public float Smoothing;//0.075
    Vector3 JoyStkRot;//(optional)This is to swing the view of the camera. Made for Xbox controller.
    
	void Update ()
    {
        Vector3 NewPos = Target.position + Offset;
        JoyStkRot = new Vector3 (Input.GetAxis("Joystick X") * Rotation * 10, 0f, 0f);
        transform.position = Vector3.Lerp(transform.position, JoyStkRot + NewPos, Smoothing);
        transform.LookAt(Target);

        //print(Input.GetAxis("Joystick X"));
        
	}
}
