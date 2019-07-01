using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMovement : MonoBehaviour
{
	private Rigidbody2D rb;


	//walking
	public float moveSpeed;
	private float horizontalInput = 0f;

	//Jumping
	public Transform feetPos; // the position of the feet to determine weather or not it is on the ground.
	public LayerMask whatIsGround; // a layer mask to determine what is ground
	public float jumpForce;

	private void Awake()
	{
		rb = transform.GetComponent<Rigidbody2D>();
	}

	
	public void Move(bool grounded, float jump, float direction)
	{
		//check to see weather or not on the ground.
		grounded = Physics2D.OverlapCircle(feetPos.position, 0.3f, whatIsGround);

		if (grounded && jump != 0)
		{
			rb.AddForce(Vector2.up * jumpForce);
		}

		//Move the player
		rb.position += new Vector2(direction * Time.deltaTime, 0f);

	
	}

}


