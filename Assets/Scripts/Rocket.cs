using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public Vector2 speed;
    private Rigidbody2D rb;

    private Vector3 basePos;
    private Quaternion baseRot;

    void Start () {
        rb = this.GetComponent<Rigidbody2D>();

        basePos = transform.position;
        baseRot = transform.rotation;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private void FixedUpdate() {
        Vector2 direction = rb.velocity;
        transform.right = direction;
    }

    public void Go(){
        rb.constraints = RigidbodyConstraints2D.None;
        rb.velocity = speed;

        //Reset();
    }

    public void Reset()
    {
        transform.position = basePos;
        transform.rotation = baseRot;

        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        rb.velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Astronaut") {
            GameObject parent = other.gameObject.transform.parent.gameObject;
            //Destroy(other.gameObject);
            //Destroy(parent);
            DestroyObject(parent);
        }                             
    }

    private void OnCollisionEnter2D(Collision2D collision){

        //if (collision.gameObject.tag == "Planet")
        //Reset();
        Debug.Log("asdf");
    }
}
