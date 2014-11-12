using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	public GameObject obj;
	public GameObject player;
	void Awake()
	{

	}
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			Destroy(gameObject);
			Instantiate(obj,this.transform.position,this.transform.rotation);
			Destroy(c.gameObject);
			//Application.LoadLevel("result");
		}
	}
}
