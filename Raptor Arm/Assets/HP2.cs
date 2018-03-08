using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP2 : MonoBehaviour {
public SimpleHealthBar healthBar;
public int current;
public int max;
	// Use this for initialization
	void Start (){
		current = 100;
		max = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
		current = current - 1;
		healthBar.UpdateBar( current, max );
		}
		
		
	}
}
