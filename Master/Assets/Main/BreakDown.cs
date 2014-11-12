using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BreakDown : MonoBehaviour {
	public List<GameObject> BreakBlock = new List<GameObject>();
	public AudioClip audioclip;
	AudioSource audiosource;

	void Start()
	{

		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;

	}
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D c) {
		if(c.tag == "Player")
		{
			for(int i=0;i<4;i++)
			{
				Instantiate(BreakBlock[i],transform.position,transform.rotation);
			}
			Debug.Log("toota");
			audiosource.PlayOneShot(audioclip);
			Destroy(gameObject);

		}
	
	}

}
