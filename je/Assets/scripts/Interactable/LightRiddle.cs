using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRiddle : MonoBehaviour
{
	LightInteractable[] linkedLights;
	public bool riddleFinished;
	public GameObject	door;
	private AudioSource	res;
    // Start is called before the first frame update
    void Start()
    {
        linkedLights = Object.FindObjectsOfType<LightInteractable>();

            door.SetActive(true);

		res = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		if(riddleFinished)
			return;
        for (int i = 0; i < linkedLights.Length; i++)
		{
			if(!linkedLights[i].isOn){
				return;
			}
		}
		riddleFinished = true;
		
    	door.SetActive(false);

			res.Play();


    }
}
