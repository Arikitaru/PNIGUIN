using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	public float speed;

	void Update ()
	{
		float mouseInput = Input.GetAxis ("Mouse X");
		Vector3 lookHere = new Vector3 (0, mouseInput, 0);
		transform.Rotate (lookHere);
		transform.Translate (Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);
	}
}






//	public float speed = 5f;
//	private Vector3 moveDirection = Vector3.zero;
//
//	void Update () 
//		{
//			CharacterController controller = GetComponent<CharacterController>();
//			if (controller.isGrounded)
//				{
//					moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//					moveDirection = Transform.TransformDirection(moveDirection);
//					moveDirection = Vector3.ClampMagnitude(moveDirection, 1);
//					moveDirection *= speed;
//				}
//
//		controller.Move(moveDirection * Time.deltaTime);
//	}
//}









