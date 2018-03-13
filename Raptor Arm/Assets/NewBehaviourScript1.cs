using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
	public AudioSource Fire;
	public AudioClip CLip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while (Input.GetKey("q")){
			Fire.Play();
		}
			
		
	}
}
