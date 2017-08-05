using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G1 : MonoBehaviour {

	private float upForce = 0.6f;

	private Rigidbody myRigidbody;

	private bool isupButtonDown = false;

	private bool isdownButtonDown = false;

	// Use this for initialization
	void Start () {

		myRigidbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		if (this.isupButtonDown)
		{
			this.myRigidbody.AddForce(0, this.upForce, 0);
		}
		else if (this.isdownButtonDown)
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
