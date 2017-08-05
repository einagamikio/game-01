using System.Collections;
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

	private bool isupButtonDown = false;

	private bool isdownButtonDown = false;


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

		if (this.isupButtonDown)
		{
			this.myRigidbody.AddForce(0, this.upForce, 0);
		}
		else if (isdownButtonDown)
		{
			this.myRigidbody.AddForce(0, -this.upForce, 0);
		}

	}

	//左ボタンを押し続けた場合の処理（追加）
	public void GetdownButtonDown()
	{
		this.isdownButtonDown = true;
	}
	//左ボタンを離した場合の処理（追加）
	public void GetdownButtonUp()
	{
		this.isdownButtonDown = false;
	}

	//右ボタンを押し続けた場合の処理（追加）
	public void GetupButtonDown()
	{
		this.isupButtonDown = true;
	}
	//右ボタンを離した場合の処理（追加）
	public void GetupButtonUp()
	{
		this.isupButtonDown = false;
	}
}
