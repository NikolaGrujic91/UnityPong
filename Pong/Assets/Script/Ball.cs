using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    float sx;
    float sy;

	// Use this for initialization
	void Start () {
        sx = Random.Range(0, 2) == 0 ? -1 : 1;
        sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10) * sx, Random.Range(5, 10) * sy, 0);
	}
	
}
