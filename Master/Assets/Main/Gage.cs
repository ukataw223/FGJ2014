using UnityEngine;
using System.Collections;

public class Gage : MonoBehaviour {
	public Texture texture;
	public Vector2 pos = new Vector2(20,300);
	public float MinX = 20;
	public float MaxX = 30;
	public float MinY = 50;
	public float MaxY = 200;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		if(GameManager.gage > 0)
		{
			GUI.DrawTexture(new Rect(pos.x,pos.y,MaxX,-MaxY * (GameManager.gage / 100.0f)),texture);
		}
	}
}
