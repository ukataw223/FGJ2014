using UnityEngine;
using System.Collections;

public class resultButton : MonoBehaviour {

	public AudioClip audioclip;

	#region PRIVATE_MEMBER_VARIABLES
	private AudioSource audiosourse;
	private float posY;
	private float firstPosY;
	private bool mode;
	#endregion // PRIVATE_MEMBER_VARIABLES
	
	// Use this for initialization
	void Start () 
	{
		audiosourse = gameObject.GetComponent<AudioSource> ();
		audiosourse.clip = audioclip;

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
		CheckTap();
		if(Input.GetMouseButtonDown(0))
		{
			if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
			{
				audiosourse.PlayOneShot(audioclip);
				//Application.LoadLevel("title");
				Reset();
				FadeManager.Instance.LoadLevel("title",1.0f);
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
						audiosourse.PlayOneShot(audioclip);
						//Application.LoadLevel("title");
						Reset();
						FadeManager.Instance.LoadLevel("title",1.0f);

					}
				}
			}
		}
	}
	void Reset()
	{
		GameManager.gage = 100;
		GameManager.Global_timer = 0;
	}
}
