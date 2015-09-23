﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour

{

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}
