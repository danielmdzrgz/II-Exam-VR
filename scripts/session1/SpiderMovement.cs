using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    // ############################################
    // Ejercicio 5
    public ChairNotificator[] chairNotificator;
    // ############################################

    public float distanceToDisplace = 20.0f;
    public GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < chairNotificator.Length; i++)
            chairNotificator[i].OnZombieProximity += MoveToZombie;
    }


    // Update is called once per frame
    void Update()
    {

    }

    // Ejercicio 5
    void MoveToZombie()
    {
        Vector3 direction = zombie.transform.position - transform.position;
        direction.Normalize();
        direction.y = zombie.transform.position.y;
        transform.Translate(direction * distanceToDisplace * Time.deltaTime);
    }
}
