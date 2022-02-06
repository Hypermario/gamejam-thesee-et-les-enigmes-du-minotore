using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtRiddle : MonoBehaviour
{
    public PressurePad goodPad;
	public GameObject	door;
	public AudioSource	res;

	public AudioSource	miss;

    void Start()
    {
    }
    public void PressurePadActivate(PressurePad curPad)
    {
        if(curPad == goodPad)
        {
            door.SetActive(false);
			res.Play();
        }
        else
        {
            door.SetActive(true);
			miss.Play();
        }
    }
}
