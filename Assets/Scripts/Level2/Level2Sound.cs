using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Sound : MonoBehaviour {

	public AudioSource lavaSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime == 0) {
			lavaSound.Pause ();
		} else {
			lavaSound.UnPause ();
		}
	}
}
