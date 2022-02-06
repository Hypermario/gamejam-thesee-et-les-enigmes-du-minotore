using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
	public float		speed;
	
	private int			isActive;
	private Rigidbody2D	rb;
	private SMask mask;
	private Animator animator;
	private CameraController camController;
	// Start is called before the first frame update
	void Start()
	{
		camController = GameObject.FindObjectOfType<CameraController>();
		isActive = 1;
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		mask = GameObject.FindObjectOfType<SMask>();
		mask.Teleport(transform);
	}

	// Update is called once per frame
	void Update()
	{
		if (isActive == 1)
		{
			float inputX = Input.GetAxis("Horizontal");
			float inputY = Input.GetAxis("Vertical");
			rb.velocity = new Vector2(inputX * speed, inputY * speed);
			if(inputX != 0 || inputY != 0)
			{
				animator.SetBool("Walk", true);
				animator.SetFloat("SpeedX", inputX);
				animator.SetFloat("SpeedY", inputY);
			}
			else
			{
				animator.SetBool("Walk", false);
			}
		}
		if (Input.GetButtonDown("Change") && isActive == 0)
		{
			camController.ChangePlayer(camController.Player1);
			isActive = 1;
			
		}
		else if (Input.GetButtonDown("Change") && isActive == 1)
		{
			isActive = 0;
			camController.ChangePlayer(camController.Player2);
			rb.velocity = Vector2.zero;
		}
	}
	public void	Tp(Transform pos)
	{
		transform.position = pos.position;
		mask.Teleport(transform);
	}
}
