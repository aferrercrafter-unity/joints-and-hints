using UnityEngine;

public class MetodosUnity : MonoBehaviour
{
	private Collider collider;

	void Awake ()
	{
		print ("Awake");

		collider = GetComponent<Collider> ();
	}

	void Start ()
	{
		print ("Start");	
	}



	void FixedUpdate ()
	{
		print ("Fixed Update");
	}



	void Update ()
	{
		print ("Update " + Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Time.timeScale = 0.0f;
		}
		if (Input.GetKeyUp (KeyCode.Space))
		{
			Time.timeScale = 1f;
		}
	}

	void LateUpdate ()
	{
		transform.LookAt (Vector3.zero);
	}
}
