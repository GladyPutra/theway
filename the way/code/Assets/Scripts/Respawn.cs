using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour {
	[SerializeField]private Transform Player;
	[SerializeField]private Transform SpawnPoint;
	public int health;
	public Text liveText;

	void Start()
	{
		liveText.text = "Life : " + health;
	}

	void OnTriggerEnter(Collider other)
	{
		health = health - 1;
		liveText.text = "Life : " + health;
		Player.transform.position = SpawnPoint.transform.position;

		if (health == 0) {
			Application.LoadLevel (6);
		}
	}
}
