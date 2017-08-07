using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socondCamera : MonoBehaviour {

	private GameObject subcam;

	public bool end;
	private GameObject ball;
	
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
			subcam.GetComponent<Camera>().depth +=0.003f;
		}
	
	}
}