﻿using UnityEngine;
using System.Collections;

public class MoveWithPlayer : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
	}
}
