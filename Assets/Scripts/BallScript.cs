using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public float Speed = 15.0f;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Jump") && rb.velocity == new Vector3(0, 0, 0))
        {
            rb.AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
        }
	}
}
