using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subcamera : MonoBehaviour {

	public bool end;
	private GameObject ball;
	private float speed;

	// Use this for initialization
	void Start () {

		this.ball = GameObject.Find("ball");

	}
	
	// Update is called once per frame
	void Update () {

		end = ball.GetComponent<ball>().isEnd;

		speed = 1;

		if (end)
		{
			//idouを3.5秒後に呼び出す
			Invoke("idou", 6.0f);

			if (this.gameObject.transform.position.z >= this.ball.transform.position.z)
			{
				this.speed = 0;
			}
		}

	}

	void idou()
	{

		transform.Translate(-speed, 0, 0);
	}

}
