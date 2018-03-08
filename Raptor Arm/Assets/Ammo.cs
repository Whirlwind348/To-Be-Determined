using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {
	public Image Counter;
	public int BulletCount;
	public RectTransform Dial;
	public Vector3 Rot;
	public bool Reloading;
		// Use this for initialization
	void Start () {
		Counter.fillAmount = 1f;
		BulletCount = 100;
		Reloading = false;
	}

	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown(KeyCode.R)){
			Reloading = true;
			StopCoroutine (Reload ());
			StartCoroutine (Reload ());
		}
		if (Reloading == false) {
			if (Input.GetMouseButtonDown (0) && Counter.fillAmount != 0) {
				if (Counter.fillAmount != 0f) {
					Counter.fillAmount = Counter.fillAmount - 0.030f;
					BulletCount = BulletCount - 1;
				}
			}
		}
	}
	IEnumerator Reload ()
	{
		if (BulletCount != 100 && Counter.fillAmount != 1) {
			GetComponent<Animator> ().SetTrigger ("Reload");
			BulletCount = 100;
				while (Counter.fillAmount != 1)
				{
					Dial.Rotate(Vector3.forward * Time.deltaTime);
					Counter.fillAmount = Counter.fillAmount + 0.030f;
				yield return new WaitForSeconds(0.05f);
				}
			}
		Reloading = false;
	}
}
