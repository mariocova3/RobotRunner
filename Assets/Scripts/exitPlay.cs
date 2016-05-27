using UnityEngine;
using System.Collections;

public class exitPlay : MonoBehaviour 
{

	private AudioSource audio;

	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump")) 
		{
			audio.Play ();
		}
	}
}
