using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtRiddle : MonoBehaviour
{
    public PressurePad goodPad;
	public GameObject	door;

    public void PressurePadActivate(PressurePad curPad)
    {
        if(curPad == goodPad)
        {
            door.SetActive(false);
        }
        else
        {
            door.SetActive(true);
        }
    }
}
