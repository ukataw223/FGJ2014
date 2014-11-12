using UnityEngine;
using System.Collections;

public class DigSound : MonoBehaviour {
	public AudioClip audioclip;
	AudioSource audiosource;

	// Use this for inuitialization
	void Start () {
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		audiosource.PlayOneShot (audioclip);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
