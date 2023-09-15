using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu_StartMenu : MonoBehaviour {

	//public string facebookLink;
	//public string twitterLink;
	//public string moreGameLink;

	public Image soundImage;
	public Image musicImage;
	public Sprite soundOn;
	public Sprite soundOff;

	public Sprite musicOn;
	public Sprite musicOff;
	public AudioSource mainMusic;

	SoundManager soundManager;

	// Use this for initialization
	void Start () {
		
		/*if (AudioListener.volume == 0)
			soundImage.sprite = soundOff;
		else
			soundImage.sprite = soundOn;*/

		soundManager = FindObjectOfType<SoundManager> ();
		int bgMusic = PlayerPrefs.GetInt("music");
		if(bgMusic == 0) {
			mainMusic.volume = 0;
			musicImage.sprite = musicOff;
		}
	}
	
	public void TurnSound(){
		if (AudioListener.volume == 0) {
			AudioListener.volume = 1;
			soundImage.sprite = soundOn;
		} else {
			AudioListener.volume = 0;
			soundImage.sprite = soundOff;
		}

		SoundManager.PlaySfx (soundManager.soundClick);
	}

	public void TurnMusic(){
		//Debug.Log ("should turn music off", gameObject);

		if (mainMusic.volume == 0) {
			mainMusic.volume = 0.2f;
			musicImage.sprite = musicOn;
			PlayerPrefs.SetInt ("music", 1);
		}else {
			mainMusic.volume = 0;
			musicImage.sprite = musicOff;
			PlayerPrefs.SetInt ("music", 0);
		}

		SoundManager.PlaySfx (soundManager.soundClick);
	}

	/*public void OpenTwitter(){
		Application.OpenURL (twitterLink);

		SoundManager.PlaySfx (soundManager.soundClick);
	}

	public void OpenFacebook(){
		Application.OpenURL (facebookLink);

		SoundManager.PlaySfx (soundManager.soundClick);
	}*/
}
