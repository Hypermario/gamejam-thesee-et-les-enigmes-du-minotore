using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
	public int buildIndexScene;
	public void RestartButton(){
		SceneManager.LoadScene(buildIndexScene);
		Debug.Log("yes");
	}
}
