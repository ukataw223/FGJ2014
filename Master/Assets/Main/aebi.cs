using UnityEngine;
using System.Collections;

public class aebi : MonoBehaviour {
	
	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
				str = "" + Score.ancientEbifurai;
				guitext.text = str;
		}
}
