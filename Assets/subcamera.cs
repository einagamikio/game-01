using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subcamera : MonoBehaviour {

	public float speed = 5f;

	public bool end;
	private GameObject ball;


	// Use this for initialization
	void Start () {

		this.ball = GameObject.Find("ball");

	}
	
	// Update is called once per frame
	void Update () {

		end = ball.GetComponent<ball>().isEnd;

		if (end)
		{
			//idouを3.5秒後に呼び出す
			Invoke("idou", 10.0f);
		}

	}

	void idou()
	{

		transform.Translate(-speed, 0, 0);
	}
}
