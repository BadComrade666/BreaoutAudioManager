using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballInitialVelocity = 600f;

	private Rigidbody rb;
	private bool ballInPlay;

	// Use this for initialization
	void Awake () {

		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && ballInPlay == false)
		{
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
    		SoundManager.instance.PaddleSound ();
		}
		
	}

	void OnCollisionEnter (Collision collision)

	// just call single function, use tags in SoundManager

	{

		{
			if (collision.gameObject.tag == "Bricks")

				SoundManager.impactType = 1;
		}

		{
			if (collision.gameObject.tag == "Walls")

				SoundManager.impactType = 2;
		}

		{
			if (collision.gameObject.tag == "Paddle")

				SoundManager.impactType = 3;
		}

		SoundManager.instance.ImpactSound ();
	}
}
