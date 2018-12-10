using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadePlayerMovement : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	private void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;
	}
}