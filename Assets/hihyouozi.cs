using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hihyouozi : MonoBehaviour {

	public bool end;
	public bool ends;
	private GameObject ball;

	// Use this for initialization
	void Start () {

		this.ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {

		end = ball.GetComponent<ball>().isEnd;
		if (end)
		{
			gameObject.SetActive(false);
		}


		ends = ball.GetComponent<ball>().isEnds;
		if (ends)
		{
			gameObject.SetActive(false);
		}

	}
}
