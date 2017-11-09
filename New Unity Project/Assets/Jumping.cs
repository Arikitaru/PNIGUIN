using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Jumping : MonoBehaviour 
{
	[Range (1, 10)]
	public float jumpVelocity;
	public float JumpCooldown;
	bool canJump = true;

	void Update ()
	{
		if (Input.GetButtonDown ("Jump")) 
			TryJump ();
	}

	IEnumerator JumpSpamBlock()
	{
		canJump = false;
		yield return new WaitForSeconds (JumpCooldown);
		canJump = true;
		yield break;
	}

	void TryJump()
	{
		if (!canJump)
			return;
		Jump ();
		StartCoroutine (JumpSpamBlock ());
	}

	void Jump()
	{
			GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
	}
}

