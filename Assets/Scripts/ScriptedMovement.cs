using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScriptedMovement : MonoBehaviour
{
	private GameObject guy;

	public bool spot1arrived = false;

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
		while (counter.count == 1) {
			anim.SetInteger ("Condition", 0);
			if (dist > 10) {
				anim.SetInteger ("Condition", 1);
				transform.LookAt (guy.transform);
				transform.position = Vector3.MoveTowards (transform.position, guy.transform.position, moveSpeed * Time.deltaTime);

			} 
			else {
				anim.SetInteger ("Condition", 3);
			}
		}
		while (counter.count == 2) {
			
		}


		
	}
}