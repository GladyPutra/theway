using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void PlayAgain()
	{

		Application.LoadLevel(3);

	}

	public void NextLevel()
	{

		Application.LoadLevel(4);

	}

	public void MainMenu()
	{
		Application.LoadLevel(1);
	}
}