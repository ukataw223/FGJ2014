using UnityEngine;
using System.Collections;

public class BreakBlockController1 : MonoBehaviour {
	Vector2 direction = new Vector2(-10,-10);
	void Start()
	{
		gameObject.rigidbody2D.AddForce (direction);
	}

	// Update is called once per frame
	void FixedUpdate () {
		if(transform.position.y <= -10.0f)
		{
			Destroy(gameObject);
		}
	}
}
