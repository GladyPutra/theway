using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	public GameObject character;

	void followCharacter()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(0, 0, 1);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position -= new Vector3(0, 0, 1);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(1, 0, 0);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position -= new Vector3(1, 0, 0);
		}
	}

	void Update()
	{
		followCharacter();
	}
}
