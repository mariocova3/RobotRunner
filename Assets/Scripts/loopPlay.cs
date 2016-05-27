using UnityEngine;
using System.Collections;

public class loopPlay : MonoBehaviour 
{

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
		}
	}

	IEnumerator PauseAndPlay()
	{
		yield return new WaitForSeconds (9);
		audio.Play ();
	}
}
