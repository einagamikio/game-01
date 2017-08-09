using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socondCamera : MonoBehaviour {

	private GameObject subcam;

	public bool end;
	private GameObject ball;

	float time = 0.0f;

	// Use this for initialization
	void Start () {
		
		this.subcam = GameObject.Find("subCamera");
		this.ball = GameObject.Find("ball");
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
				subcam.GetComponent<Camera>().depth = 1;

			}
		}
	
	}
}