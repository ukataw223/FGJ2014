using UnityEngine;
using System.Collections;

public class PlayerControl2D : MonoBehaviour {

	public float MinX = 0;
	public float MaxX = 4.0f;
	Vector3 prev;
	float timer = 0;
	bool CanMoveFlag = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		prev = this.transform.position;
		if(CanMoveFlag)
		{
			float x = Input.GetAxis ("Horizontal");

			if (x < 0) {
				transform.position += Vector3.left;
				CanMoveFlag = false;

			} else if (x > 0)
			{
				transform.position += Vector3.right;
				CanMoveFlag = false;
			}
		}
		if(transform.position.x <= MinX)
		{
			transform.position = new Vector3(MinX,transform.position.y,transform.position.z);
		}
		if(transform.position.x >= MaxX)
		{
			transform.position = new Vector3(MaxX,transform.position.y,transform.position.z);
		}

		if(!CanMoveFlag){
			timer += Time.deltaTime;
			if(timer >= 0.20f)
			{
				timer = 0;
				CanMoveFlag = true;
			}
		}

	}
	void FixedUpdate()
	{

	}
	/*
	void OnCollisionEnter2D(Collision2D c)
	{
		if(c.gameObject.tag == "Block" || c.gameObject.tag == "Treasure")
		{
			Destroy(c.gameObject);
			audioSource.PlayOneShot(audioclip);
			Debug.Log("toota");
		}
		else if(c.gameObject.tag == "Damage")
		{
			transform.position = prev;
		}
	}
	*/
}
