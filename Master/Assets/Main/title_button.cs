using UnityEngine;
using System.Collections;

public class title_button : MonoBehaviour {
	public AudioClip audioclip;
	AudioSource audiosource;
	#region PRIVATE_MEMBER_VARIABLES
	private float posY;
	private float firstPosY;
	private bool mode;
	bool isTap = false;
	#endregion // PRIVATE_MEMBER_VARIABLES
	
	// Use this for initialization
	void Start () 
	{
		//isTap = false;
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		mode = true; //true is up movement
		firstPosY = this.transform.position.y;
		posY = firstPosY;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	
	/// <summary>
	/// Fixeds the update.
	/// </summary>
	void FixedUpdate()
	{
		if(!isTap)
		{
			CheckTap();
			if(Input.GetMouseButtonDown(0))
			{
				if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
				{
					audiosource.PlayOneShot(audioclip);
					//load
					isTap = true;
					FadeManager.Instance.LoadLevel("demo00",1.0f);
				}
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
						audiosource.PlayOneShot(audioclip);
						//load
						FadeManager.Instance.LoadLevel("demo00",1.0f);
						isTap = true;
					}
				}
			}
		}
	}

}
