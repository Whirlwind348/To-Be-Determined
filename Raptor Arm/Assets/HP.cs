using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {
public SimpleHealthBar healthBar;
public float hi; 
public int current = 100;
public int max = 100;
public GameObject IM;
RectTransform rt;

	// Use this for initialization
	void Start (){
		hi = 380;
		IM = GameObject.Find("HP") as GameObject;
		 rt = IM.GetComponent<RectTransform>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
		current = current - 1;
		hi = hi - 5f;
		healthBar.UpdateBar( current, max );
		}
		
		rt.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 0, hi);
	}
}
