using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour {

	AudioSource musicSource;

	// Use this for initialization
	void Start () {

		musicSource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.M))
		{
			musicSource.mute = !musicSource.mute;
		}
		
	}
}
