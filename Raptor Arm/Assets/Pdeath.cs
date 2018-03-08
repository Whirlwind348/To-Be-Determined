using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pdeath : MonoBehaviour {
	[SerializeField]
	public Toggle toggle;

	public void Awake ()
	{
		// 1
		if (!PlayerPrefs.HasKey("PD"))
		{
			PlayerPrefs.SetInt("PD", 1);
			toggle.isOn = true;
			PlayerPrefs.Save ();
		}
		// 2
		else
		{
			if (PlayerPrefs.GetInt ("PD") == 0)
			{
				toggle.isOn = false;
			}
			else
			{
				toggle.isOn = true;
			}
		}
	}
}
