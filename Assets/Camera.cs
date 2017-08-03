﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	//ballのオブジェクト
	private GameObject ball;
	//ballとカメラの距離
	private float difference;

	public float upForce = 0.57f;

	private Rigidbody myRigidbody;

	private float coefficient = 0.95f;

	public bool end;


	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody>();

		//ballのオブジェクトを取得
		this.ball = GameObject.Find("ball");

		//ballとカメラの位置（z座標）の差を求める
		this.difference = ball.transform.position.z - this.transform.position.z;
	}

	// Update is called once per frame
	void Update()
	{
		end = ball.GetComponent<ball>().isEnd;

		if (this.end)
		{
			this.upForce *= this.coefficient;
			this.myRigidbody.velocity = new Vector3(0, 0, 0);
		}

		//ballの位置に合わせてカメラの位置を移動
			this.transform.position = new Vector3(0, this.transform.position.y, this.ball.transform.position.z - difference);

		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetMouseButton(0))
		{
			this.myRigidbody.AddForce(0, this.upForce, 0);
		}
		else if (Input.GetKey(KeyCode.RightArrow) || Input.GetMouseButton(1))
		{
			this.myRigidbody.AddForce(0, -this.upForce, 0);
		}

	}
}
