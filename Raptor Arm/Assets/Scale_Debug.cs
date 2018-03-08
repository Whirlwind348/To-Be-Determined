using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale_Debug : MonoBehaviour {
public GameObject image;
	// Use this for initialization
	void Start () {
		Debug.Log(image.transform.localScale);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
