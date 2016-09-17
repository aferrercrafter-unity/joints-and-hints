using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float movimientoZ = Input.GetAxis("Vertical");
		transform.Translate (Vector3.forward * movimientoZ * Time.deltaTime * 10);

		if (Input.GetButton ("Saltar"))
		{
			
		}


		if (Input.GetKey (KeyCode.Space)) {

			// Disparar

		}

	}
}
