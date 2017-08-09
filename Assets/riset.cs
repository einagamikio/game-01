using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riset : MonoBehaviour {

	private GameObject reset;
	private GameObject resets;

	public bool end;
	private GameObject ball;

	float time = 0.0f;

	// Use this for initialization
	void Start () {

		this.ball = GameObject.Find("ball");
		reset = GameObject.Find("Button");
		resets = GameObject.Find("Button 2");
		reset.SetActive(false);
		resets.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

		end = ball.GetComponent<ball>().isEnd;
		if (end)
		{
			time = time + Time.deltaTime;
			if (time >= 5.0f)
			{

				time = 0;
				reset.SetActive(true);
				resets.SetActive(true);
			}
		}


	}
}
