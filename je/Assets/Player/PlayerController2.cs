using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
	public float		speed;
	private int			isActive;
	private Rigidbody2D	rb;
	// Start is called before the first frame update
	void Start()
	{
		isActive = 0;
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (isActive == 1)
		{
			float inputX = Input.GetAxis("Horizontal");
			float inputY = Input.GetAxis("Vertical");
			rb.velocity = new Vector2(inputX * speed, inputY * speed);
		}
		if (Input.GetKeyDown(KeyCode.Alpha1) && isActive == 1)
		{
			isActive = 0;
			rb.velocity = Vector2.zero;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) && isActive == 0)
			isActive = 1;
	}
}
