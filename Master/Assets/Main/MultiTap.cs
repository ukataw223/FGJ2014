using UnityEngine;
using System.Collections;

public class MultiTap : MonoBehaviour {		

	GameObject player;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame

	/// <summary>
	/// Fixeds the update.
	/// </summary>
	void Update()
	{
		if(player != null)
			CheckTap(); 
	}
	
	/// <summary>
	/// Checks the tap.
	/// </summary>
	void CheckTap()
	{
		if( 0 < Input.touchCount || Input.GetMouseButtonDown(0))
		{

			for(int i = 0; i < Input.touchCount; ++i)
			{
				Debug.Log("tooru");
				Touch t = Input.GetTouch(i);
				if(t.phase == TouchPhase.Ended )
				{
					if(gameObject.guiTexture.HitTest(t.position))
					{
						player.transform.position += Vector3.right;
					}
					/*
					if(gameObject.guiTexture.HitTest(t.position))
					{
						//float y = player.transform.position.y;
						　　　　　　　　　　　　//ここにタップした時の処理
						//Vector3 pos = new Vector3(t.position.x,y,0);
						//player.transform.position = pos;
					}
					*/
				}
			}
			if(gameObject.guiTexture.HitTest( Input.mousePosition))
			{
				Debug.Log("iei");

				player.transform.position += Vector3.right;

			}

		}
	}
}
