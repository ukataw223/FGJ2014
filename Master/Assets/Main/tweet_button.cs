using UnityEngine;
using System.Collections;

public class tweet_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/// <summary>
	/// Fixeds the update.
	/// </summary>
	void FixedUpdate()
	{
		CheckTap();
		if(Input.GetMouseButtonDown(0))
		{
			if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
			{
				string message = "" + Score.totalM + "m掘り進めたよ！ #fgj2014 #fgj14ngy #ここほれ！シャチホコくん！";
				Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
			}
		}
	}
	
	/// <summary>
	/// Checks the tap.
	/// </summary>
	void CheckTap()
	{
		if( 0 < Input.touchCount)
		{
			for(int i = 0; i < Input.touchCount; ++i)
			{
				Touch t = Input.GetTouch(i);
				if(t.phase == TouchPhase.Began )
				{
					if(this.gameObject.guiTexture.HitTest(t.position))
					{
						string message = "" + Score.totalM + "m掘り進めたよ！ #fgj2014 #fgj14ngy #ここほれ！シャチホコくん！";
						Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
					}
				}
			}
		}
	}
}
