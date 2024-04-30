using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    //public TrailRender t;
    //private float velocityMax = 200f;

	void Awake () {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(4f,0,4f, ForceMode.Impulse);
	}

     private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Bat") {
            rb.useGravity = true;
            //t.enabled = true;
        }
     }
}

//4f,0,4f