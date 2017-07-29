using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

	public float speed = 0.08f;

	private float upForce = 0.6f;

	private Rigidbody myRigidbody;


	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(0, 0, this.speed);

		if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetMouseButton(0))
		{
			this.myRigidbody.AddForce(0, this.upForce, 0);


		}
		else if (Input.GetKey(KeyCode.RightArrow) || Input.GetMouseButton(1))
		{
			this.myRigidbody.AddForce(0, -this.upForce, 0);

		}

	}
}
