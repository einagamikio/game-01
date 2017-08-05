using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {

	private GameObject ball;
	private float L;
	private float startPos = a;
	private float goalPos = 1.0f;

	// Use this for initialization
	void Start () {
		
		this.ball= GameObject.Find("ball");
		this.L = goalPos - ball.transform.position.z/683;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3(L, 1, 1);
	}
}
