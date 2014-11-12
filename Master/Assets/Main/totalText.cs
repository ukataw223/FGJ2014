using UnityEngine;
using System.Collections;

public class totalText : MonoBehaviour {
	public GUIText guitext;
	private string str;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		str = "" + Score.goldenEbifurai * 500 +
						Score.goldenKishimen * 500 +
						Score.goldenMisokatsu * 500 +
						Score.goldenTebasaki * 500 +
						Score.ancientEbifurai * 100 +
						Score.ancientKishimen * 100 +
						Score.ancientMisokatsu * 100 +
						Score.ancientTebasaki * 100 +
						Score.normalEbifurai * 10 +
						Score.normalKishimen * 10 +
						Score.normalMisokatsu * 10 +
						Score.normalTebasaki * 10 +
						Score.IeyasuArmor * 1000 +
						Score.IeyasuKabuto * 1000 +
						Score.IeyasuSword * 1000 +
						Score.totalM * 10;
		guitext.text = str;
	}
}
