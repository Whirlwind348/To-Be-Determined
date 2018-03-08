using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(AudioSource))]
public class MouseOver : MonoBehaviour 
, IPointerEnterHandler{
public AudioClip over;
AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
public void OnPointerEnter(PointerEventData eventData)
     {
	audioSource.PlayOneShot(over);
     }
}
