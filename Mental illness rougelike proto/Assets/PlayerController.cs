using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	private movement controller;
	private Shooting shooting;

	private float horizontalInput = 0f;
	private float jumpInput = 0f;


	private void Awake()
	{
		controller = transform.GetComponent<movement>();
		shooting = transform.GetComponent<Shooting>();
	}

	// Update is called once per frame
	void Update()
    {
		horizontalInput = Input.GetAxisRaw("Horizontal");
		jumpInput = Input.GetAxisRaw("Jump");

		shooting.shoot();
	}

	private void FixedUpdate()
	{
		controller.Move(false, jumpInput, horizontalInput);
	}

}
