using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void PlayAgain()
	{

		Application.LoadLevel(2);

	}

	public void NextLevel()
	{

		Application.LoadLevel(3);

	}

	public void MainMenu()
	{
		Application.LoadLevel(1);
	}
}