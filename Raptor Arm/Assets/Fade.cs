using System.Collections;
using UnityEngine;
using UnityEngine.Audio;


public class Fade : MonoBehaviour {
public AudioMixerSnapshot Indoors;
public AudioMixerSnapshot Outdoors;




void Start () {



}

void Update () {

}

public void OnTriggerEnter(Collider collision){
Indoors.TransitionTo (2.0f);
}
}