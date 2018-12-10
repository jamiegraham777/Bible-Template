using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GoliathMovement : MonoBehaviour
{
	private GameObject guy;
	private GameObject guy2;
	private GameObject davidlocation;

	public bool spot1arrived = false;

	public float moveSpeed = 2.0f;

	private float dist;
	private float dist2;
	private float dist3;
	CharacterController controller;
	Animator anim;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator> ();
	}

	void Awake(){
		guy = GameObject.Find ("Gmove1");
		guy2 = GameObject.Find ("Gmove2");
		davidlocation = GameObject.Find ("move2");
	}

	public IEnumerator DoTheDance() {
		yield return new WaitForSeconds(5); // waits 3 seconds
	}

	void Update()
	{
		anim.SetInteger ("Condition", 0);
		dist = Vector3.Distance (guy.transform.position, transform.position);
		if (counter.count == 1) {
			//anim.SetInteger ("Condition", 0);
			if (dist > 10) {
				anim.SetInteger ("Condition", 1);
				transform.LookAt (guy.transform);
				transform.position = Vector3.MoveTowards (transform.position, guy.transform.position, moveSpeed * Time.deltaTime);

			} 
			else {
				anim.SetInteger ("Condition", 0);
			}
		}
		dist2 = Vector3.Distance (guy2.transform.position, transform.position);
		if (counter.count == 2) {
			if (dist2 > 10) {
				transform.LookAt (guy2.transform);
				anim.SetInteger ("Condition", 1);
				transform.position = Vector3.MoveTowards (transform.position, guy2.transform.position, moveSpeed * Time.deltaTime);

			} 
			else {
				anim.SetInteger ("Condition", 0);
			}
		}
		dist3 = Vector3.Distance (davidlocation.transform.position, transform.position);
		if (counter.count == 9) {
			if (dist3 < 10) {
				transform.LookAt (davidlocation.transform);
				anim.SetInteger ("Condition", 0);
			}
		}
	}
}