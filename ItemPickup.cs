using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {


	// Use this for initialization
	void OnTriggerEnter (Collider other) {

		if (other.gameObject.CompareTag ("Pick Up")) {
			Debug.Log ("hit");
			other.gameObject.SetActive (false);
		}
	}

}
