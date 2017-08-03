using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUP : MonoBehaviour {

	private GameObject efe;

	public AudioSource audio;

	public GameObject up;

	public GameObject cam;

	// Use this for initialization
	void Start () {

		this.efe = GameObject.Find("energyBlast");

		this.audio = GetComponent<AudioSource>();

		this.up = GameObject.Find("ball");

		this.cam = GameObject.Find("Main Camera");

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
			this.efe.GetComponent<ParticleSystem>().Play();

			audio.Play();

			this.up.GetComponent<ball>().upForce += 0.01f;
			this.cam.GetComponent<Camera>().upForce += 0.01f;
		}
	}
}
