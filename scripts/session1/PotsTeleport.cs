using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotsTeleport : MonoBehaviour
{
    // ############################################
    // Ejercicio 4
    public TableauNotificator tableauNotificator;
    // ############################################

    // Start is called before the first frame update
    void Start()
    {
        tableauNotificator.OnZombieProximity += TeleportRandomly;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Ejercicio 4
    void TeleportRandomly()
    {
        float randomX = Random.Range(-5, 2);
        float randomZ = Random.Range(-10, 8);
        transform.position = new Vector3(randomX, transform.position.y, randomZ);
    }
}
