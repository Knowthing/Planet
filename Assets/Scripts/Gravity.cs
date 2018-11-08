using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public float G = 100f;
    public GameObject[] targets = null;

    private void FixedUpdate()
    {
        if (targets != null) {
            foreach ( GameObject target in targets) {
                Attract(target);
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Attract(GameObject target) {
        Rigidbody2D targetRb = target.GetComponent<Rigidbody2D>();
        Rigidbody2D thisRb = this.GetComponent<Rigidbody2D>();
        Vector3 direction = thisRb.position - targetRb.position;
        float distance = direction.magnitude;

        float forceMagnitude = (thisRb.mass * targetRb.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        targetRb.AddForce(force);
    }
}
