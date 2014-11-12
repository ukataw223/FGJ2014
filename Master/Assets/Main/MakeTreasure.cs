using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MakeTreasure : MonoBehaviour {
	public List<GameObject> treasure = new List<GameObject>();
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c)
	{
		if(c.tag == "Player")
		{
			Destroy(gameObject);
			int num = Random.Range(0,treasure.Capacity);
			Instantiate (treasure [num], transform.position + Vector3.up, transform.rotation);
		}
	}
}
