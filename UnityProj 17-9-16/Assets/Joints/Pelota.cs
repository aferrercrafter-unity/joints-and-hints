using UnityEngine;

public class Pelota : MonoBehaviour
{
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
		Vector3 fuerzaRandomHaciaArriba;

		fuerzaRandomHaciaArriba.x = Random.Range (-fuerza, fuerza);
		fuerzaRandomHaciaArriba.y = Random.Range (fuerza, 20);
		fuerzaRandomHaciaArriba.z = Random.Range (-fuerza, fuerza);

		rb.AddForce (fuerzaRandomHaciaArriba, ForceMode.Impulse);
	}
}
