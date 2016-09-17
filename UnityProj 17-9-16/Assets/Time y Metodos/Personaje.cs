using UnityEngine;

public class Personaje : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (Vector3.up * Time.deltaTime * -10f);

	}
}
