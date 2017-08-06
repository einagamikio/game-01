using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

	public float speed = 0.08f;

	public float upForce=0.6f;

	private Rigidbody myRigidbody;

	//動きを減速させる係数（追加）
	public float coefficient = 0.95f;
	//ゲーム終了の判定（追加）
	public bool isEnd = false;

	private GameObject efe;

	private GameObject sphere;

	public AudioSource audio;

	private bool isupButtonDown = false;
	
	private bool isdownButtonDown = false;


	// Use this for initialization
	void Start()
	{

	    myRigidbody = GetComponent<Rigidbody>();

		this.efe = GameObject.Find("sprite_realExplosion_c_example");

		this.sphere = GameObject.Find("Sphere");

		this.audio = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update()
	{

		if (this.isEnd)
		{
			this.speed *= this.coefficient;
			this.upForce *= this.coefficient;
			transform.localScale = new Vector3(0, 0, 0);
			
			this.myRigidbody.velocity = new Vector3(0, 0, 0);
			sphere.SetActive(false);

		}

		transform.Translate(0, 0, speed);



		if (this.isupButtonDown)
		{
			this.myRigidbody.AddForce(0, this.upForce, 0);


		}
		else if (this.isdownButtonDown)
		{
			this.myRigidbody.AddForce(0, -this.upForce, 0);

		}


	}

	void OnTriggerEnter(Collider other)
	{

		//障害物に衝突した場合（追加）
		if (other.gameObject.tag == "syougaiTag"|| other.gameObject.tag == "wallTag"|| other.gameObject.tag == "lightTag")
		{
			this.isEnd = true;
			this.efe.GetComponent<ParticleSystem>().Play();

			audio.Play();

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
