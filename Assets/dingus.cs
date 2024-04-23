using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KModkit;

public class dingus : MonoBehaviour {

	public KMBombInfo bomb;
	public KMSelectable playbutton;
	public KMSelectable patpat;
	public AudioSource dingusnoise;
	public AudioClip music;
	public AudioClip miau;

	bool playing;

	void Start () {
		playbutton.OnInteract += delegate () {
			PlayMusic ();
			return false;
		};
		patpat.OnInteract += delegate () {
			Meow ();
			return false;
		};
		dingusnoise.clip = music;
		dingusnoise.loop = true;
	}

	void PlayMusic(){
		if (playing) {
			dingusnoise.Stop ();
			playing = false;
		} else {
			dingusnoise.Play ();
			playing = true;
		}
	}
	void Meow(){
		dingusnoise.PlayOneShot (miau);
	}
}
