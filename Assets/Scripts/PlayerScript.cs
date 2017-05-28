using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float Accel = 100.0f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);
	}
}
