using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform tramsform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0,2.0f, 0);
        transform.Rotate(angle);
	}
}
