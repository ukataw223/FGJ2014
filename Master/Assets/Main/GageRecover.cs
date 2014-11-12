using UnityEngine;
using System.Collections;

public class GageRecover : MonoBehaviour {
	public int recover = 50;
	// Use this for initialization
	void Start () {
		GameManager.gage += recover;
		if(GameManager.gage >= 100)
		{
			GameManager.gage = 100;
		}
	}
}
