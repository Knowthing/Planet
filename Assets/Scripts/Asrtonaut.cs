using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asrtonaut : MonoBehaviour {

    private float speed = 150f;

    void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
