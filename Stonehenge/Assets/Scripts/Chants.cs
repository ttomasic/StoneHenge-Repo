using UnityEngine;
using System.Collections;

public class Chants : MonoBehaviour {

	string input;
	AudioSource audio;
	AudioClip boop;

	// Use this for initialization
	void Awake () 
	{
		audio = GetComponent<AudioSource>();
		boop = Resources.Load("boop") as AudioClip;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey(KeyCode.Mouse0) && audio.pitch < 2.5f)
			audio.pitch += .025f;

		if (Input.GetKey(KeyCode.Mouse1) && audio.pitch > 0.75f)
			audio.pitch -= .025f;
	
		input = Input.inputString;

		if(Input.anyKey)
		{
			switch (input)
			{
			case "a":
				print ("itsssa aaaaaaaa!!");
				break;
			case "b":
				if(!audio.isPlaying)
				{
				audio.clip = boop;
					audio.Play();
				}
				break;
			default:
				print ("default");
				break;
			}

		}
	}



}
