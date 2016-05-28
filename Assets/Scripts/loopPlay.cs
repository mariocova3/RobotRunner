using UnityEngine;
using System.Collections;

public class loopPlay : MonoBehaviour 
{
	bool SpaceWasPressed = false;

	private AudioSource audio;

	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource> ();
		StartCoroutine (PauseAndPlay ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonUp ("Jump")) 
		{
			audio.Stop ();
			SpaceWasPressed = true;
		}
	}

	IEnumerator PauseAndPlay()
	{
		yield return new WaitForSeconds (9);
		if (SpaceWasPressed == false) 
		{
			audio.Play ();
		}
	}
}
