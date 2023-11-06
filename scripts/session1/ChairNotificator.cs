using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairNotificator : MonoBehaviour
{
    public delegate void ChairEvent();
    public event ChairEvent OnZombieProximity;

    public GameObject zombie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // #############################################################################
        // Ejercicio 5
        if(collision.collider.gameObject.name == "Zombie_Reference") {
            // Debug.Log("Collided with " + collision.collider.gameObject.name);
            OnZombieProximity();
        }
        // #############################################################################
    }
}
