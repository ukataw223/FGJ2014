using UnityEngine;
using System.Collections;

public class nteba : MonoBehaviour {
	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.normalTebasaki;
		guitext.text = str;
	}
}
