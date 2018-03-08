using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phys : MonoBehaviour
{

	// Use this for initialization
	void OnMouseDown() 
	{
		GetComponent<Rigidbody>().AddForce(-transform.forward*500);
		GetComponent<Rigidbody>().useGravity = true;
	}
	
}
