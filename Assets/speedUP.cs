using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUP : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{

		//障害物に衝突した場合（追加）
		if (other.gameObject.tag == "syougaiTag")
		{
			GameObject.Find("ball").GetComponent<ball>().speed += 0.01f;
		}
	}
}
