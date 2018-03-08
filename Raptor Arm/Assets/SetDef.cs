using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDef : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator animator = GetComponent<Animator>();
		animator.SetBool ("Highlighted", false);
		animator.SetBool ("Normal", true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
