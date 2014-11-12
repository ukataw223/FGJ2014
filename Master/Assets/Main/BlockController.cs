using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {
	public float TimeSpan = 1.0f;
	public float MaxHeight = 10;
	Vector3 ofs = new Vector3(0,1,0);
	float time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(time >= TimeSpan)
		{
			transform.position = transform.position + ofs;
			time = 0;
		}
		if(transform.position.y >= MaxHeight)
		{
			Destroy(gameObject);
		}
		time += Time.deltaTime;
	}
	void OnTriggerEnter2D(Collider2D c)
	{
	}
}
