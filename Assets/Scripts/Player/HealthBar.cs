using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
	//public Transform forceGroundSprite;
	public Player player;
	public Image foreGroundBar;
	//public SpriteRenderer forceGroundRenderer;
//	public Color maxColor;
//	public Color minColor;


	void Start () {
		player = FindObjectOfType<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		var healthPercent = (float) player.Health / player.maxHealth;
		//forceGroundSprite.localScale = new Vector3 (healthPercent, 1, 1);
		foreGroundBar.fillAmount = healthPercent;
//		forceGroundRenderer.color = Color.Lerp (minColor, maxColor, healthPercent);
	}
}
