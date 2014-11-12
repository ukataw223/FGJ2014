using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D c)
	{
		Debug.Log("aa");
		if(c.tag == "Block")
		{
			Destroy(c.gameObject);
		}
	}
}
