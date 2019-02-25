using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton


public class SoundManager : MonoBehaviour {

	public AudioClip brick, wall, paddle, youWin, youLose, lifeLoss;
	public static int impactType = 0;
	public static SoundManager instance = null;

	public AudioSource soundSource;
    public AudioSource soundSource02;


    // Use this for initialization
    void Start () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
	}
		
		public void ImpactSound()
	{
		if (impactType == 1)

			soundSource.clip = brick;

		if (impactType == 2)

			soundSource.clip = wall;

		if (impactType == 3)

			soundSource.clip = paddle;

		soundSource.Play ();
	}


	public void PaddleSound()

	{
		soundSource02.clip = paddle;
		soundSource02.Play ();
	}

	public void YouWin()

	{
		soundSource02.clip = youWin;
		soundSource02.Play ();
	}

	public void YouLose()

	{
		soundSource02.clip = youLose;
		soundSource02.Play ();
	}

	public void LifeLoss()

	{
		soundSource02.clip = lifeLoss;
		soundSource02.Play ();
	}

}
