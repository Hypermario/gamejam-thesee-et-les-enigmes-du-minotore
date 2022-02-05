using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
	public float		speed;
	
	private int			isActive;
	private Rigidbody2D	rb;
	private SMask mask;
	// Start is called before the first frame update
	void Start()
	{
		isActive = 1;
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
		}
		if (Input.GetKeyDown(KeyCode.Alpha1) && isActive == 0)
			isActive = 1;
		if (Input.GetKeyDown(KeyCode.Alpha2) && isActive == 1)
		{
			isActive = 0;
			rb.velocity = Vector2.zero;
		}
	}
	public void	Tp(Transform pos)
	{
		transform.position = pos.position;
		mask.Teleport(transform);
	}
}
