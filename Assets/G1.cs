using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class G1 : MonoBehaviour {

	public bool end;
	private GameObject ball;
	private GameObject item;


	private Rigidbody myRigidbody;

	public float coefficient = 0.95f;


	// Use this for initialization
	void Start () {

		this.item = GameObject.Find("Item");
		this.ball = GameObject.Find("ball");
		myRigidbody = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update()
	{

		end = ball.GetComponent<ball>().isEnd;
		if (end)
		{
			this.item.GetComponent<Item>().upForce*= this.coefficient;
			this.myRigidbody.velocity = new Vector3(0, 0.2f, 0);
		}

	}
}
