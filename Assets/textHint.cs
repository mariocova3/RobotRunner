using UnityEngine;
using System.Collections;

public class textHint : MonoBehaviour 
{
	
	public Renderer rend;

	// Use this for initialization
	IEnumerator Start () 
	{
		rend = GetComponent<Renderer> ();
		yield return new WaitForSeconds (10);
		Destroy (gameObject);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GameObject.Find("Robot Kyle").GetComponent<PlayerScript>().HasCollidedOnce) 
		{
			StartCoroutine (DisplayHint());
		}
	}

	IEnumerator DisplayHint()
	{
		rend.enabled = true;
		yield return new WaitForSeconds (3);
		rend.enabled = false;
		Destroy (gameObject);
	}
}
