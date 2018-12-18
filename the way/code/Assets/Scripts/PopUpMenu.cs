using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour {

	public GameObject window;
	public GameObject player;
	public Text messageField;

	void Start()
	{
		window.SetActive (false);
	}

	public void show(string message)
	{
		messageField.text = message;
		window.SetActive (true);
		player.SetActive (false);
	}

	public void Hide()
	{
		window.SetActive (false);
		player.SetActive (true);

	}

	public void Exit()
	{
		Application.LoadLevel (1);
	}
}
