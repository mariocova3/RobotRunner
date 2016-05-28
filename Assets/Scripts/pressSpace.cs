using UnityEngine;
using System.Collections;

public class pressSpace : MonoBehaviour {

	private Animation anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animation> ();
		StartCoroutine(TextAnimation());
	}

	IEnumerator TextAnimation()
	{
		yield return new WaitForSeconds (8);
		anim.Play ("Text Animation");
	}
}
