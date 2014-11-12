using UnityEngine;
using System.Collections;

public class Break : MonoBehaviour {
	public Vector2 velocity = new Vector2 (5, 10);
	// Use this for initialization
	void Start () {
		gameObject.rigidbody2D.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
