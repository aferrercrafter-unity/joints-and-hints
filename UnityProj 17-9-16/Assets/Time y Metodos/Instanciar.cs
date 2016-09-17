using UnityEngine;

public class Instanciar : MonoBehaviour {

	public GameObject prefab;

	void Update () {
		if (Input.anyKeyDown) {
			Instantiate(prefab);
		}
	}
}
