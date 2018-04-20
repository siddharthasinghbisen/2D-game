using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour {

    public float jumpPower = 10.0f;
    Rigidbody2D myRIgidbody;
    bool isGrounded = false;
	// Use this for initialization
	void Start () {
        myRIgidbody = transform.GetComponent<Rigidbody2D>();
	}
	

	void FixedUpdate () {
		
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            myRIgidbody.AddForce(Vector3.up * (jumpPower * myRIgidbody.mass * myRIgidbody.gravityScale * 20.0f));
        }

    }
     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
