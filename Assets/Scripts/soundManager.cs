using UnityEngine;
using System.Collections;

public class soundManager : MonoBehaviour 
{

	private AudioSource audio;
	public AudioClip loopedAudio;
	public AudioClip exitAudio;

	bool SpaceWasPressed = false;


	// Use this for initialization
	IEnumerator Start () 
	{
		audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);
		if (SpaceWasPressed == false) 
		{
			audio.clip = loopedAudio;
			audio.Play ();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonUp("Jump"))
		{
			SpaceWasPressed = true;
			audio.clip = exitAudio;
			audio.Play ();
			StartCoroutine (LoadNextScene ());
		}
	}

	IEnumerator LoadNextScene ()
	{
		yield return new WaitForSeconds (audio.clip.length);
		audio.Stop ();
		Application.LoadLevel("Main");
	}
}
