using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	//carPrefabを入れる
	public GameObject G1Pre;

	public GameObject G2Pre;

	public GameObject G3Pre;

	//スタート地点
	private int startPos = -310;
	//ゴール地点
	private int goalPos = 340;
	//アイテムを出すx方向の範囲
	private float posRange = 40.0f;

	// Use this for initialization
	void Start()
	{

			//一定の距離ごとにアイテムを生成
			for (int i = startPos; i < goalPos; i += 30)
			{
			if (i > -200)
			{
				i -= 5;
			}
			else if (-200 < i && i < -50)
			{
				i -= 5;
			}
			else if (-50 < i && i < 200)
			{
				i = 5;
			}
			else if (200 < i)
			{
				i -= 5;
			}


			//レーンごとにアイテムを生成
			for (float j = -0.35f; j < 0.35; j += 0.1f)
				{
					//アイテムの種類を決める
					int item = Random.Range(1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 5);
					

					if (1 <= item && item <= 2)
					{
						GameObject G1 = Instantiate(G1Pre) as GameObject;
						G1.transform.position = new Vector3(G1.transform.position.x, posRange * j, i + offsetZ);
					}
				}
				for (float j = -0.35f; j < 0.35; j += 0.06f)
				{
					//アイテムの種類を決める
					int item = Random.Range(1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 5);
					

					if (3 <= item && item <= 5)
					{
						//G2を生成
						GameObject G2 = Instantiate(G2Pre) as GameObject;
						G2.transform.position = new Vector3(G2.transform.position.x, posRange * j, i + offsetZ);
					}
				}
				for (float j = -0.35f; j < 0.35; j += 0.08f)
				{
					//アイテムの種類を決める
					int item = Random.Range(1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 5);
					

					if (6 <= item && item <= 7)
					{
						//G3を生成
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
