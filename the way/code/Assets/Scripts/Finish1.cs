using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish1 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{
		
		Application.LoadLevel (5);

	}
}
