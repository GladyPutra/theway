using UnityEngine;
using System.Collections;

public class PilihLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void Level1()
	{

		Application.LoadLevel(2);

	}

	public void Level2()
	{

		Application.LoadLevel(3);

	}

	public void Level3()
	{

		Application.LoadLevel(4);

	}

	public void Back()
	{

		Application.LoadLevel(1);

	}
}