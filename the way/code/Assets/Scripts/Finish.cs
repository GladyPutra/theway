using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void PlayAgain()
	{

		Application.LoadLevel(4);

	}

	public void SelectLevel()
	{

		Application.LoadLevel(7);

	}

	public void MainMenu()
	{

		Application.LoadLevel(1);

	}
}