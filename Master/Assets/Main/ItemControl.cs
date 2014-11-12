using UnityEngine;
using System.Collections;

public class ItemControl : MonoBehaviour {
	public float IsTime = 1.0f;
	public AudioClip audioclip;
	AudioSource audiosourse;

	float timer = 0;

	// Use this for initialization
	void Start () {
		audiosourse = gameObject.GetComponent<AudioSource> ();
		audiosourse.clip = audioclip;
		if(gameObject.tag != "Bomb")
			audiosourse.PlayOneShot (audioclip);
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer >= IsTime)
		{
			timer = 0;
			Destroy(gameObject);
		}
	}
}
