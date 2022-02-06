using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
	public float		speed;
	private int			isActive;
	private Rigidbody2D	rb;
	private Animator animator;
	private CameraController camController;
	// Start is called before the first frame update
	void Start()
	{
		camController = GameObject.FindObjectOfType<CameraController>();
		isActive = 0;
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (isActive == 1)
		{
			float inputX = Input.GetAxis("Horizontal");
			float inputY = Input.GetAxis("Vertical");
			if(inputX != 0 || inputY != 0)
			{
				animator.SetBool("Walk", true);
				animator.SetFloat("SpeedX", inputX);
			}
			else
			{
				animator.SetBool("Walk", false);
			}
			rb.velocity = new Vector2(inputX * speed, inputY * speed);
		}
		if (Input.GetButtonDown("Change") && isActive == 1)
		{
			isActive = 0;
			camController.ChangePlayer(camController.Player1);
			rb.velocity = Vector2.zero;
		}
		else if (Input.GetButtonDown("Change") && isActive == 0)
		{
			camController.ChangePlayer(camController.Player2);
			isActive = 1;
		}
	}
}
