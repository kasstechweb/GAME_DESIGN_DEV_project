using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class myprefs : MonoBehaviour {

	public int currentWorld;
	public string loadscene;
	public GameObject Locked;
	public GameObject errorBox;
	public Text errorText;
	int firstStart = 1; // set to 0 if wanna delete all keyprefs
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("firstStart", 1);
		if(firstStart == 0) {
			PlayerPrefs.DeleteAll ();
		}
		if (PlayerPrefs.HasKey ("firstStart")) {
			Debug.Log (PlayerPrefs.GetInt("firstStart"));
		} else {
			PlayerPrefs.SetInt ("firstStart", 1);
		}

		if(PlayerPrefs.GetInt ("level1Finished") == 1
			&& currentWorld == 2
			&& PlayerPrefs.HasKey ("level1Finished")) { // level 1 is fininshed
			// remove the lock
			Locked.SetActive (false);
		}
		if(PlayerPrefs.GetInt ("level2Finished") == 1
			&& currentWorld == 3
			&& PlayerPrefs.HasKey ("level2Finished")) { // level 1 is fininshed
			// remove the lock
			Locked.SetActive (false);
		}

	} // finish start

	public void LoadScene(){
		if(currentWorld == 1) {
			GlobalValue.worldPlaying = currentWorld;

			LoadingSreen.Show ();

			SceneManager.LoadSceneAsync (loadscene);
		} else if (currentWorld == 2) { // if clickinig on level 2
			if (PlayerPrefs.GetInt ("level1Finished") == 1 && PlayerPrefs.HasKey ("level1Finished")) { // check level 1 is fininshed
				GlobalValue.worldPlaying = currentWorld;

				LoadingSreen.Show ();

				SceneManager.LoadSceneAsync (loadscene);
			} else {
				errorBox.SetActive (true);
				errorText.text = "You must Fininsh hospital Level Before going into supermarket Level!";
				Debug.Log ("level 1 is not fininshed!");
			}
		} else if (currentWorld == 3) { // if clicking on level 3
			if (PlayerPrefs.GetInt ("level2Finished") == 1 && PlayerPrefs.HasKey ("level2Finished")) { // check level 2 is fininshed
				GlobalValue.worldPlaying = currentWorld;

				LoadingSreen.Show ();

				SceneManager.LoadSceneAsync (loadscene);
			} else {
				errorBox.SetActive (true);
				errorText.text = "You must Fininsh supermarket Level Before going into cafe Level!";

				Debug.Log ("level 2 is not fininshed!");
			}
		}

	}

	public void closePopUp() {
		errorBox.SetActive (false);
	}


	/*public void LoadLevel2(){
		if (PlayerPrefs.HasKey ("level1Finish")) {
			level1Finish = PlayerPrefs.GetInt ("level1Finish");
			if(level1Finish == 1) {
				Debug.Log ("level1 is finisehd");
			}else {
				Debug.Log ("level 1 is not finished");
			}
			Debug.Log (level1Finish);
		}
	}*/

	// Update is called once per frame
	//void Update () {

	//}
}
