using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableauNotificator : MonoBehaviour
{
    public delegate void TableauEvent();
    public event TableauEvent OnZombieProximity;

    private bool executedEvent = false;
    public GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // #############################################################################
        // Ejercicio 4
        Vector3 distance = zombie.transform.position - transform.position;
        // Debug.Log(distance.magnitude);
        if (distance.magnitude < 6.5f && !executedEvent)
        {
            OnZombieProximity();
            executedEvent = true;
        }
        else if (distance.magnitude > 6.5f)
        {
            executedEvent = false;
        }
        // #############################################################################
    }
}
