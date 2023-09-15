using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuInfo : MonoBehaviour {

	public GameObject Helper;
	public GameObject helperPanel;

	// Use this for initialization
	void Start () {
		HideHelper ();
	}

	public void ShowHelper(){
		Helper.SetActive (true);
		helperPanel.SetActive (true);
	}

	public void HideHelper(){
		Helper.SetActive (false);
		helperPanel.SetActive (false);
	}
}
