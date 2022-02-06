using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TextLayer : MonoBehaviour
{
	private Renderer render;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(render == null)
			render = GetComponent<Renderer>();
        render.sortingOrder = 3;
    }
}
