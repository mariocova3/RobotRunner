﻿using UnityEngine;
using System.Collections;

public class mainPlay : MonoBehaviour 
{

	private AudioSource audio;

	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource> ();
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
