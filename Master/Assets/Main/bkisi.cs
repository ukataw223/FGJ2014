using UnityEngine;
using System.Collections;

public class bkisi : MonoBehaviour {

	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.normalKishimen;
		guitext.text = str;
	}
}
