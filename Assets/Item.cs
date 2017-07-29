using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	//carPrefabを入れる
	public GameObject G1Pre;

	public GameObject G2Pre;

	public GameObject G3Pre;

	//スタート地点
	private int startPos = -260;
	//ゴール地点
	private int goalPos = 290;
	//アイテムを出すx方向の範囲
	private float posRange = 40.0f;

	// Use this for initialization
	void Start()
	{
		//一定の距離ごとにアイテムを生成
		for (int i = startPos; i < goalPos; i += 10)
		{

				//レーンごとにアイテムを生成
				for (float j = -0.5f; j < 0.5; j+=0.1f)
				{
					//アイテムの種類を決める
					int item = Random.Range(1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 5);
				    //60%コイン配置:30%車配置:10%何もなし
				if (1 <= item && item <= 2)
				{
					GameObject G1 = Instantiate(G1Pre) as GameObject;
					G1.transform.position = new Vector3(G1.transform.position.x, posRange * j, i + offsetZ);
				}
				else if (3 <= item && item <= 5)
				{
					//コインを生成
					GameObject G2 = Instantiate(G2Pre) as GameObject;
					G2.transform.position = new Vector3(G2.transform.position.x, posRange * j, i + offsetZ);
				}
				else if (6 <= item && item <= 7)
				{
					//車を生成
					GameObject G3 = Instantiate(G3Pre) as GameObject;
					G3.transform.position = new Vector3(G3.transform.position.x, posRange * j, i + offsetZ);
				}
				}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
