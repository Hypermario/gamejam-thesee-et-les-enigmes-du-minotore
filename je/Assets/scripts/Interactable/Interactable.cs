using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	bool playerIsIn;
	private void Update() 
	{
		if(playerIsIn && Input.GetButtonDown("Fire1"))
			Interact();
	}
	public void OnTriggerStay2D(Collider2D other) {
		if(other.CompareTag("Player")){
			playerIsIn = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("Player")){
			playerIsIn = false;
		}
	}

	public virtual void Interact()
	{

	}
}
