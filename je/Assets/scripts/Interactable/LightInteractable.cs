using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInteractable : Interactable
{
	public bool isOn;
	public SpriteRenderer[] linkedSprites;
	public float enableTime = 1f;
	public override void Interact()
	{
		if(isOn)
			return;
		
		StartCoroutine(EnableLight());
		isOn = true;
	}

	IEnumerator EnableLight()
	{
		float timer = 0f;
		while(timer <= enableTime)
		{
			timer += Time.deltaTime;
			float alpha = Mathf.Lerp(0f, 1f, timer/enableTime);
			for (int i = 0; i < linkedSprites.Length; i++)
			{
				LightSprite(linkedSprites[i], alpha);
			}
			yield return null;
		}
	}

	void LightSprite(SpriteRenderer sprite, float alpha)
	{
		Color c = sprite.color;
		c.a = alpha;
		sprite.color = c;

	}
}
