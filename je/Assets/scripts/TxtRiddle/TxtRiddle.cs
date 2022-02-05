using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtRiddle : MonoBehaviour
{
    public PressurePad goodPad;

    public void PressurePadActivate(PressurePad curPad)
    {
        if(curPad == goodPad)
        {
            Debug.Log("Yes");
        }
        else
        {
            Debug.Log("Nope");
        }
    }
}
