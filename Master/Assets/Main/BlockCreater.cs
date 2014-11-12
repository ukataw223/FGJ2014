using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockCreater : MonoBehaviour {
	public List<GameObject> blocks = new List<GameObject>();	
	public int Percent0 = 70;
	public int Percent1 = 15;
	public int Percent2 = 10;
	public int Percent3 = 5;

	public Vector3 FirstPos = new Vector3(0,0,0);
	public int Width = 6;
	public int Height = 4;
	public float TimeSpan = 1.0f;
	float time = GameManager.Global_timer;

	// Use this for initialization
	void Awake () {
		for(int i=0; i<=Height;i++)
		{
			for (int j=0; j<Width; j++) {
				int num = Random.Range(1,Percent0 + Percent1 + Percent2 + Percent3);
				int blocknum = 0;
				if(num <= Percent0)
				{
					blocknum = 0;
				}else if(num <= Percent1 + Percent0)
				{
					blocknum = 1;
				}
				else if(num <= Percent0 + Percent1 + Percent2)
				{
					blocknum = 2;
				}else{
					blocknum = 3;
				}
				Instantiate(blocks[blocknum], FirstPos + Vector3.right * j + Vector3.down * i, transform.rotation);	
			}
		}
	}
	void Update()
	{
		time += Time.deltaTime;
	}
	// Update is called once per frame
	void FixedUpdate () {
		if(time >= TimeSpan)
		{
	
			for(int i=0;i<Width;i++)
			{
				int num = Random.Range(1,Percent0 + Percent1 + Percent2 + Percent3);
				int blocknum = 0;
				if(num <= Percent0)
				{
					blocknum = 0;
				}else if(num <= Percent1 + Percent0)
				{
					blocknum = 1;
				}
				else if(num <= Percent0 + Percent1 + Percent2)
				{
					blocknum = 2;
				}else{
					blocknum = 3;
				}
				Instantiate(blocks[blocknum],FirstPos + Vector3.right * i + Vector3.down * (Height),transform.rotation);

			}
			GameManager.gage -= 1;
			Score.totalM ++;
			time = 0;
			if(GameManager.gage < 0)
			{
				FadeManager.Instance.LoadLevel("result",0.5f);
			}
		}
	}
}
