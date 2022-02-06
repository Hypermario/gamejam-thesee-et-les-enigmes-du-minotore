using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform	Player1;
	public Transform	Player2;
	public float		SmoothSpeed = 0.125f;
	private Transform	curPlayer;
	private Vector3		cameraPos;
	private Vector3		velocity = Vector3.zero;
	public Transform	curRoom;
	public SMask maskController;
	// Start is called before the first frame update
	void Start()
	{
		curPlayer = Player1;
	}

	// Update is called once per frame
	void Update()
	{
		// if (Input.GetButtonDown("Change"))
		// {
		// 	curPlayer = Player1;
		// 	transform.position = new Vector3(curPlayer.position.x, curPlayer.position.y, -10f);
		// 	maskController.Teleport(curPlayer);
		// }
		// else if (Input.GetKeyDown(KeyCode.Alpha2))
		// {
		// 	curPlayer = Player2;
		// 	transform.position = new Vector3(curPlayer.position.x, curPlayer.position.y, -10);
		// 	maskController.Teleport(curPlayer);
		// }
		cameraPos = new Vector3(curPlayer.position.x, curPlayer.position.y, -10f);
		transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, SmoothSpeed);
	}

	public void ChangePlayer(Transform newPlayer)
	{
		curPlayer = newPlayer;
		transform.position = new Vector3(curPlayer.position.x, curPlayer.position.y, -10f);
		maskController.Teleport(curPlayer);
	}
}
