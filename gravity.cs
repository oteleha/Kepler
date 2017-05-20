using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {
	//public float strengthOfAttraction;
	float strengthOfAttraction;
	float colliderRadius;
	float dist;
	public float strength;

	void OnTriggerStay(Collider other){
		if (other.tag == "planet"){
			dist = Vector3.Distance(other.transform.position, this.transform.position);	//find distance between planet and ship
			colliderRadius = ((other.GetComponent<SphereCollider>().radius) + 1);	//find radius of planet collider
			print("Distance to other: " + (dist/colliderRadius));	
			strengthOfAttraction = (dist/colliderRadius); //the gravity of planet is a number between 0 and 1, distance divided by radius
			Vector3 direction = other.transform.position - transform.position;
			this.GetComponent<Rigidbody> ().AddForce (strengthOfAttraction * direction);

		}

	}
}

/* Currently working on making the low values of the strengthOfAttraction lower and the
 * high values higher. Currently set at 0-1 but we want it to be like 0-2 (more 
 * strength when closer to planet).
 */


