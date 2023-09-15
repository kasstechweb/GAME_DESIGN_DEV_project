using UnityEngine;
using System.Collections;

public class GameFinishFlag : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.GetComponent<Player> () == null)
			return;

		GameManager.Instance.GameFinish ();

		int currentLevel = GlobalValue.worldPlaying;
		Debug.Log ("current level: " + currentLevel); 
		if(currentLevel == 1) {
			PlayerPrefs.SetInt ("level1Finished", 1);
		}else if(currentLevel == 2) {
			PlayerPrefs.SetInt ("level2Finished", 1);
		}else if(currentLevel == 3) {
			PlayerPrefs.SetInt ("level3Finished", 1);
		}

		Debug.Log ("game finished");
	}
}
