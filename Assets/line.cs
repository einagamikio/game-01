using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {

	private GameObject ball;
	private float L;
	private float goalPos = 690.0f;

	// Use this for initialization
	void Start () {
		this.ball= GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {
		this.L = (this.ball.transform.position.z-10) / goalPos;
		this.transform.localScale = new Vector3(L * 1, 1, 1);
	}
}
