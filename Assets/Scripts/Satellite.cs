using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour {

    public GameObject satellite = null;

    private Vector2 centre;

    private float rotSpeed = 0.5f;
    private float radius = 2f;
    private float angle = 0.0f;
	
	void Start () {
        centre = transform.position;
	}
	
	void Update () {
        angle += rotSpeed * Time.deltaTime;

        Vector2 offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;
        satellite.transform.position = centre + offset;

        satellite.transform.Rotate(Vector3.forward * Time.deltaTime * 150f);
    }

}
