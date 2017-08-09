using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour {

	private GameObject great;
	private GameObject thanks;

	public bool end;
	private GameObject ball;

	// Use this for initialization
	void Start () {

		this.ball = GameObject.Find("ball");
		great = GameObject.Find("great");
		thanks = GameObject.Find("thanks");
		great.SetActive(false);
		thanks.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		end = ball.GetComponent<ball>().isEnd;
		if (end)
		{
			{
				great.SetActive(true);
				thanks.SetActive(true);
			}
		}

	}
}
