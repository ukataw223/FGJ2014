using UnityEngine;
using System.Collections;

public class GageDamage : MonoBehaviour {
	public int Damage = 30;
	public float time_span = 0.7f;
	public GameObject explosion;
	float time = 0;
	// Use this for initialization
	void Start () {
		GameManager.gage -= Damage;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time >= time_span)
		{
			Destroy (gameObject);
			Instantiate(explosion,transform.position,transform.rotation);
		}
	}
}
