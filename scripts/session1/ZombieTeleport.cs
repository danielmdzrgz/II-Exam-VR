using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // #############################################################################
        // Ejercicio 3
        if (Input.GetAxis("Teleport") == 1) {
            float randomX = Random.Range(-5, 2);
            float randomZ = Random.Range(-10, 8);
            transform.position = new Vector3(randomX, transform.position.y, randomZ);
        }
        // #############################################################################
    }
}
