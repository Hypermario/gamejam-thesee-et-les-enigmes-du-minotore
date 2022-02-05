using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
	public Camera		camera;
	public Transform	pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D other)
	{
		camera.SendMessage("CameraMoveR", pos);
		print("TRIGGER CAMERA");
	}
}
