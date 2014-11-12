using UnityEngine;
using System.Collections;

public class ateba : MonoBehaviour {
	
	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.ancientTebasaki;
		guitext.text = str;
	}
}
