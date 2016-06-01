using UnityEngine;
using System.Collections;

public class text_02Manager : MonoBehaviour {

	private Animation anim;

	// Use this for initialization
	IEnumerator Start () 
	{
		anim = GetComponent<Animation> ();
		yield return new WaitForSeconds (2.5f);
		anim.Play ();
		yield return new WaitForSeconds (2);
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
