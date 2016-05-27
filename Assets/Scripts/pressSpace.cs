using UnityEngine;
using System.Collections;

public class pressSpace : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool up = Input.GetButtonUp ("Jump");
		if (up) 
		{
			StartCoroutine(LoadNextScene ());
		}
	
	}

	IEnumerator LoadNextScene()
	{
		yield return new WaitForSeconds (4);
		Application.LoadLevel ("Main");
	}
}
