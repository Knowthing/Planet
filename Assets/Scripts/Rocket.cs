using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public Vector2 speed;
    Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    private void Update()
    {
        Vector2 direction = rb.velocity;
        //transform.rotation = Quaternion.AngleAxis(Mathf.Acos(direction.y), Vector3.forward);
        transform.right = direction;
    }

}
