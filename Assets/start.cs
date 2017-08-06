using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{

	// Update is called once per frame
	public void selectstage01()
	{
	
			Debug.Log("a");
	
			SceneManager.LoadScene("game 01");

	}
}
