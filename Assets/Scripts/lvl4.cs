using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lvl4 : MonoBehaviour {
	public static MenuManager Instance;


	public int currentWorld;
	public string loadscene;
	public GameObject Locked;
	public GameObject errorBox;
	public Text errorText;
	public GameObject oldClose;
	public GameObject newClose;
	public GameObject restartBtn;
	public GameObject goBtn;
	public GameObject victoryCredit;
	public GameObject victoryPanel;
	public GameObject errorBox2;
	public Text errorText2;

	// Use this for initialization
	void Start () {
		////////////////////////////// Debug Remove ////////////////////////////
		//PlayerPrefs.SetInt("level3Finished", 1);
		/// ////////////////////////////////End Debug ////////////////////////
		if(PlayerPrefs.GetInt ("level3Finished") == 1
			&& currentWorld == 4
			&& PlayerPrefs.HasKey ("level3Finished")) { // level 1 is fininshed
			// remove the lock
			Locked.SetActive (false);
		}
	}

	public void loadLvl4() {
		if (currentWorld == 4) { // if clicking on level 4
			if (PlayerPrefs.GetInt ("level2Finished") == 1 && PlayerPrefs.HasKey ("level3Finished")) { // lvl 3 fininshed
				oldClose.SetActive(false);
				errorBox.SetActive (true);

				errorText.text = "Last Level! Your friend asked you to go to a party at his house, what you say, Warrior! ";

			} else {
				errorBox2.SetActive (true);
				errorText2.text = "You must Fininsh cafe Level Before going into the last Level!";

			}

			/*if(PlayerPrefs.GetInt("level2Finished") == 1){ // check level 2 is fininshed
				GlobalValue.worldPlaying = currentWorld;

				LoadingSreen.Show ();

				SceneManager.LoadSceneAsync (loadscene);
			}*/
		}
	}
	
	public void agreeParty() {
		errorText.text = "Sorry Warrior! You have lost the battle at the last level with Coroni";
		//remove newclose
		newClose.SetActive(false);
		goBtn.SetActive (false);
		restartBtn.SetActive (true);
	}

	public void noParty() {
		errorBox.SetActive (false);
		// show credits and music
		victoryCredit.SetActive(true);
		victoryPanel.SetActive (true);
		Debug.Log("coroni defeated!");
	}

	public void RestartGame(){
		Time.timeScale = 1;
		SoundManager.PlaySfx (SoundManager.Instance.soundClick);
		LoadingSreen.Show ();
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex);
	}

}
