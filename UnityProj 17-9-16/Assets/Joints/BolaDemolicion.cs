using UnityEngine;
using System.Collections;

public class BolaDemolicion : MonoBehaviour {

	public float fuerza;

	private Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Start ()
	{
		InvokeRepeating ("AplicarFuerza", 2.0f, 2.0f);
	}

	void AplicarFuerza ()
	{
		rb.AddForce (Random.onUnitSphere * fuerza, ForceMode.Impulse);
	}
}
