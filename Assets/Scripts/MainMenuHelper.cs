using UnityEngine;
using System.Collections;

public class MainMenuHelper : MonoBehaviour {
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
