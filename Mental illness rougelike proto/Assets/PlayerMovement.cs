using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	[SerializeField]
	private controllerMovement controller;

	private float horizontalInput = 0f;

	private float jumpInput = 0f;

    // Update is called once per frame
    void Update()
    {
		horizontalInput = Input.GetAxisRaw("Horizontal");
		jumpInput = Input.GetAxisRaw("Jump");
	}

	private void FixedUpdate()
	{
		controller.Move(false, jumpInput, horizontalInput);
	}

}
