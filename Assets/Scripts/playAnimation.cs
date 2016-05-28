using UnityEngine;
using System.Collections;

public class playAnimation : MonoBehaviour 
{
	public Animation anim;

	void Start ()
	{
		anim = GetComponent<Animation> ();
	}

	// Update is called once per frame
	void Update () 
	{
		bool up = Input.GetButtonUp ("Jump");
		if (up) 
		{
				if (!anim.IsPlaying("moveCamera"))
				{
				anim.Play("moveCamera");
				}
		}
	}
}
