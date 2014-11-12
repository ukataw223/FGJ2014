using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	public AudioClip clip;
	AudioSource source;
	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		source.clip = clip;
		source.PlayOneShot (clip);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
