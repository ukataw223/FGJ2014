using UnityEngine;
using System.Collections;

public class gmiso : MonoBehaviour {
	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.goldenMisokatsu;
		guitext.text = str;
	}
}
