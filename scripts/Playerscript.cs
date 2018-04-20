using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour {

    public float jumpPower = 10.0f;
    Rigidbody2D myRIgidbody;
	// Use this for initialization
	void Start () {
        myRIgidbody = transform.GetComponent<Rigidbody2D>();
	}
	

	void FixedUpdate () {
		
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRIgidbody.AddForce(Vector3.up * (jumpPower * myRIgidbody.mass * myRIgidbody.gravityScale * 20.0f));
        }
	}
}
