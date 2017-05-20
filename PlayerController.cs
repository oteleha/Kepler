using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;

	void Start () { 
		GetComponent<Rigidbody>().useGravity = false; //ensures gravity is deselected

	}
	void Update() {


		//if any keys are hit, add relative force to make them go in relative direction, but do not stop moving after key release
		if (Input.GetKey("up")){
			GetComponent<Rigidbody>().AddRelativeForce (Vector3.forward * speed);
		}
		if (Input.GetKey("down")){
			GetComponent<Rigidbody>().AddRelativeForce (Vector3.back * speed);
		}
		if (Input.GetKey("left")){
			GetComponent<Rigidbody>().AddRelativeForce (Vector3.left * speed);
		}
		if (Input.GetKey("right")){
			GetComponent<Rigidbody>().AddRelativeForce (Vector3.right * speed);
		}
	}

}

