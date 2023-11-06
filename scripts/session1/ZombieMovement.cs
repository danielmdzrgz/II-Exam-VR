using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float rotationSpeed = 180.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // #############################################################################
        // Ejercicio 2
        float horizontalInput = Input.GetAxis("Horizontal");
        float rotationAngle = horizontalInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, rotationAngle);
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
        // #############################################################################
    }
}
