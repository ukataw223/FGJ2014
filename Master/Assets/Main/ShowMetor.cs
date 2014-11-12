using UnityEngine;
using System.Collections;

public class ShowMetor : MonoBehaviour {
	public GUIText gui;
	string str;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.totalM;
		gui.text = str;
	}
}
