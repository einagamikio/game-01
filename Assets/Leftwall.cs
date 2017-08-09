using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftwall : MonoBehaviour {

	private float speed = 0.00065f;

	public bool end;
	private GameObject ball;
	private GameObject item;

	float time = 0.0f;

	// Use this for initialization
	void Start () {
		this.ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(this.speed, 0,0);

		end = ball.GetComponent<ball>().isEnd;
		if (end)
		{
			time = time + Time.deltaTime;
			if (time >= 5.0f)
			{
				time = 0;
				gameObject.SetActive(false);

			}
		}
	}
}
