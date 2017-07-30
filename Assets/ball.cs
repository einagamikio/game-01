using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

	public float speed = 0.08f;

	private float upForce = 0.6f;

	private Rigidbody myRigidbody;

	//動きを減速させる係数（追加）
	public float coefficient = 0.95f;
	//ゲーム終了の判定（追加）
	public bool isEnd = false;


	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update()
	{

		if (this.isEnd)
		{
			this.speed *= this.coefficient;
			this.upForce *= this.coefficient;
			this.myRigidbody.velocity = new Vector3(0, 0, 0);
		}


		transform.Translate(0, 0, speed);

		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetMouseButton(0))
		{
			this.myRigidbody.AddForce(0, this.upForce, 0);


		}
		else if (Input.GetKey(KeyCode.RightArrow) || Input.GetMouseButton(1))
		{
			this.myRigidbody.AddForce(0, -this.upForce, 0);

		}

	}

	void OnTriggerEnter(Collider other)
	{

		//障害物に衝突した場合（追加）
		if (other.gameObject.tag == "syougaiTag")
		{
			this.isEnd = true;
		}
	}
}
