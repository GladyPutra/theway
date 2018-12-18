using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {
	CharacterController cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
		//if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audio.isPlaying == false ) {
		//	audio.Play();
		}
	}

