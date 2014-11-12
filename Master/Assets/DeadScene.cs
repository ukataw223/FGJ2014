using UnityEngine;
using System.Collections;

public class DeadScene : MonoBehaviour {
	float timer = 0;
	public GameObject fire;
	void Start()
	{
		Instantiate (fire, transform.position, transform.rotation);
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer >= 2.0f)
		{
			Application.LoadLevel("result");
		}
	}
}
