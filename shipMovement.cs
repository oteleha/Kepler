using UnityEngine;
using System.Collections;

public class shipMovement : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public float rotateSpeed = 30f;
	public GameObject rightEngine;
	public GameObject leftEngine;


	void Start(){

		rb = GetComponent<Rigidbody> ();
		leftEngine.SetActive (false);
		rightEngine.SetActive (false);
	}

	void Update(){

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {

			leftEngine.SetActive (false);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {


			rightEngine.SetActive (false);
		}

	}
		

	void FixedUpdate(){
		
		float LThruster = 0f, RThruster = 0f;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			
//			transform.Rotate (-Vector3.down * rotateSpeed * Time.deltaTime);
			rb.AddRelativeTorque(Vector3.up * rotateSpeed);
			leftEngine.SetActive (true);
			LThruster = 1f;
		} 

		if (Input.GetKey (KeyCode.RightArrow)) {
			
//			transform.Rotate (Vector3.down * rotateSpeed * Time.deltaTime);
			rb.AddRelativeTorque(Vector3.down * rotateSpeed);
			rightEngine.SetActive (true);
			RThruster = 1f;
		} 

		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0, 0, LThruster + RThruster);

		rb.AddRelativeForce (movement * speed);
	}

}
