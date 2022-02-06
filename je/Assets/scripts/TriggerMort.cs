using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMort : MonoBehaviour
{
	public PlayerController1		player;
	public Transform			transform;

	private AudioSource	res;
    // Start is called before the first frame update
    void Start()
    {
        
		res = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D other)
	{
		player.SendMessage("Tp", transform);
		print("TRIGGER TP");
			res.Play();
	}
}
