using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScriptedMovement : MonoBehaviour
{
	private GameObject guy;
	private GameObject guy2;

	public bool spot1arrived = false;

	public float moveSpeed = 2.0f;

	private float dist;
	private float dist2;
	CharacterController controller;
	Animator anim;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator> ();
	}

	void Awake(){
		guy = GameObject.Find ("move1");
		guy2 = GameObject.Find ("move2");
	}

	public IEnumerator DoTheDance() {
		yield return new WaitForSeconds(5); // waits 3 seconds
	}

	void Update()
	{
		dist = Vector3.Distance (guy.transform.position, transform.position);
		while (counter.count == 1) {
			//anim.SetInteger ("Condition", 0);
			if (dist > 10) {
				anim.SetInteger ("Condition", 1);
				transform.LookAt (guy.transform);
				transform.position = Vector3.MoveTowards (transform.position, guy.transform.position, moveSpeed * Time.deltaTime);

			} 
			else {
				anim.SetInteger ("Condition", 3);
			}
		}
		dist2 = Vector3.Distance (guy.transform.position, transform.position);
		while (counter.count == 2) {
			if (dist2 > 10) {
				transform.LookAt (guy2.transform);
				anim.SetInteger ("Condition", 1);
				transform.position = Vector3.MoveTowards (transform.position, guy2.transform.position, moveSpeed * Time.deltaTime);

			} 
			else {
				anim.SetInteger ("Condition", 0);
			}
		}


		
	}
}