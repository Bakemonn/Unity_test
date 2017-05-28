using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public float Speed = 30.0f;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Jump") && rb.velocity == new Vector3(0, 0, 0))
        {
            Debug.Log("GO");
            rb.AddForce((transform.forward + transform.right) * Speed, ForceMode.Impulse);
        }
	}

    void OnCollisionEnter()
    {
        rb.velocity = rb.velocity.normalized * 20;
        Vector3 vec = rb.velocity;

        if (Mathf.Abs(rb.velocity.y) < 5)
        {
            vec.y *= 5;
            rb.velocity = vec;
        }

        if(Mathf.Abs(rb.velocity.x) < 5)
        {
            vec.x *= 5;
            rb.velocity = vec;    
        }
    }
}
