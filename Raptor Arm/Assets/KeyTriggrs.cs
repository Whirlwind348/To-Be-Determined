using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggrs : MonoBehaviour {
	public Animation Walk;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.W)) {
			Walk.CrossFade("run_forward");
		} else if (Input.GetKeyDown(KeyCode.A)) {
			Walk.CrossFade("run_left");
		} else if (Input.GetKeyDown(KeyCode.D)) {
			Walk.CrossFade("run_right");
		} else if (Input.GetKeyDown(KeyCode.S)) {
			Walk.CrossFade("run_backward");
		} else {
			Walk.CrossFade("idle");
		}
	}
}
