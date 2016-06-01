using UnityEngine;
using System.Collections;

public class activateButton : MonoBehaviour 
{

	public GameObject button;

	// Use this for initialization
	IEnumerator Start () 
	{
		button.SetActive (false);
		yield return new WaitForSeconds (5);
		button.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
