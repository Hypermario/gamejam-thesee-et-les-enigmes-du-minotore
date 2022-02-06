using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolutionSound : MonoBehaviour
{
	private AudioSource	res;
	private bool	resolved = false;
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
		if (resolved == false)
		{
			resolved = true;
			res.Play();
		}
	}
}
