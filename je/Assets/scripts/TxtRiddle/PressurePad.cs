using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public float stayTime = 5f;
    private float timer;
    private TxtRiddle riddleController;
    Coroutine checkingCoroutine;
    public Transform fill;
    private Vector3 baseScale;
    private void Start()
    {
        riddleController = GameObject.FindObjectOfType<TxtRiddle>();
        baseScale = fill.localScale;
        fill.localScale = new Vector3(0, baseScale.y, baseScale.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            checkingCoroutine = StartCoroutine(Checking());
        }
    }

    IEnumerator Checking()
    {
        while(timer < stayTime)
        {
            timer += Time.deltaTime;
            fill.localScale = new Vector3( baseScale.x * timer/ stayTime, baseScale.y, baseScale.z);
            yield return null;
        }
        ActivatePressurePad();
        StopCoroutine(checkingCoroutine);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(checkingCoroutine != null)
            {
                StopCoroutine(checkingCoroutine);
                fill.localScale = new Vector3(0, baseScale.y, baseScale.z);
            }
            timer = 0f;
        }
    }

    void ActivatePressurePad()
    {
        riddleController.PressurePadActivate(this);
    }
}
