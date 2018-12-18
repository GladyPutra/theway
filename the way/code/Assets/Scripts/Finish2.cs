using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish2 : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{

		Application.LoadLevel (9);

	}
}
