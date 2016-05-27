using UnityEngine;
using System.Collections;

public class introPlay : MonoBehaviour {

	private AudioSource audio;

	private AudioSource intro;

	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource> ();
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonUp("Jump"))
		{
			audio.Stop ();
		}
	}
}
