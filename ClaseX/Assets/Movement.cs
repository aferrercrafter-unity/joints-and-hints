using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;

	float Xmovement;
	float Ymovement;
	Rigidbody rb;

	// Use this for initialization

	void Awake(){
		rb = GetComponent<Rigidbody> ();
		Xmovement = 0;
		Ymovement = 0;
	}

	void Start () {
	
	}

	void FixedUpdate () {
		rb.AddForce(Vector3.back * Xmovement);
		rb.AddForce(Vector3.right * Ymovement);
		
	}
	
	// Update is called once per frame
	void Update () {

		Xmovement = Input.GetAxis ("Horizontal") * speed;
		Ymovement = Input.GetAxis ("Vertical") * speed;

	}
}
