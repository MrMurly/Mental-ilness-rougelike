using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{

	public Rigidbody2D rb;

	[HideInInspector]
	public bool flipY = false;

	public float speed = 15f;
	// Start is called before the first frame update
    void Awake()
    {
		rb = transform.GetComponent<Rigidbody2D>();
    }

	void Update()
	{
		
	}

	private void FixedUpdate()
	{
		rb.MovePosition(Vector2.right * speed * Time.deltaTime + rb.position);
	}
}
