using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 AudioSource audio = GetComponent<AudioSource>();
        audio.PlayDelayed(1.748F);
        	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
