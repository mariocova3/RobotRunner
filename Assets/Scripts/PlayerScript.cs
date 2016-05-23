using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public GameControlScript control;
	
	float strafeSpeed = 2;
	Animator anim;
	
	bool jumping = false;
	
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed, 0f, 0f);
		
		if(transform.position.x > 3)
			transform.position = new Vector3(3, transform.position.y, transform.position.z);
		else if(transform.position.x < -3)
			transform.position = new Vector3(-3, transform.position.y, transform.position.z);
		
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Jump"))
		{
			anim.SetBool("Jumping", false);
			jumping = true;
		}
		else
		{
			jumping = false;
			if(Input.GetButtonDown("Jump"))
				anim.SetBool("Jumping", true);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Powerup(Clone)")
		{
			control.PowerupCollected();
		}
		else if(other.gameObject.name == "Obstacle(Clone)" &&
			jumping == false)
		{
			control.SlowWorldDown();
		}
		
		Destroy(other.gameObject);
	}
}
