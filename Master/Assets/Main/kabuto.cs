using UnityEngine;
using System.Collections;

public class kabuto : MonoBehaviour {
	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.IeyasuKabuto;
		guitext.text = str;
	}
}
