using UnityEngine;
using System.Collections;

public class text_01Manager : MonoBehaviour {

	private Animation anim;

	// Use this for initialization
	IEnumerator Start () 
	{
		anim = GetComponent<Animation> ();
		anim.Play ("Txt_01.1Anim");
		yield return new WaitForSeconds (1.5f);
		anim.Play ("Txt_01.2Anim");
		yield return new WaitForSeconds (1);
		Destroy (gameObject);
	}
}
