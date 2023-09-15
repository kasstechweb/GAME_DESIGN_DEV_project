using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myBGMusic : MonoBehaviour {
	public AudioSource mainMusic;

	// Use this for initialization
	void Start () {
		int bgMusic = PlayerPrefs.GetInt("music");
		if (bgMusic == 1) { // music is on
			mainMusic.volume = 0.15f;
		} else { // music is off
			mainMusic.volume = 0;
		}

	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
