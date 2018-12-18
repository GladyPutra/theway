using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish3 : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{

		Application.LoadLevel (8);

	}
}
