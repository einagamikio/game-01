using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {

	private GameObject ball;
	private float L;
	private float goalPos = 700.0f;

	// Use this for initialization
	void Start () {
		this.ball= GameObject.Find("ball");
		this.L = this.ball.transform.position.z/goalPos;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3(L, 1,1);
	}
}
