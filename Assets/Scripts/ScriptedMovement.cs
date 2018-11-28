using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptedMovement : MonoBehaviour
{
	private GameObject guy;


	public float moveSpeed = 2.0f;

	private float dist;
	CharacterController controller;
	Animator anim;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator> ();
	}

	void Awake(){
		guy = GameObject.Find ("move1");
	}

	void Update()
	{
		dist = Vector3.Distance (guy.transform.position, transform.position);
		if (dist > 5) {
			anim.SetInteger ("Condition", 1);
			transform.LookAt (guy.transform);

			transform.position = Vector3.MoveTowards (transform.position, guy.transform.position, moveSpeed * Time.deltaTime);
		} 
		else {
			anim.SetInteger ("Condition", 0);
		}
	}
}