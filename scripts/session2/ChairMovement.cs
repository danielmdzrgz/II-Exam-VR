using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairMovement : MonoBehaviour
{
    // ############################################
    // Ejercicio 4
    public TableauNotificator tableauNotificator;
    // ############################################

    // ############################################
    // Ejercicio 7
    public TableauController tableauController;
    // ############################################

    public float distanceToDisplace = 20.0f;
    public GameObject zombie;

    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        tableauNotificator.OnZombieProximity += MoveToZombie;
        tableauController.OnCameraLook += MoveToOriginalPosition;

        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Ejercicio 4
    void MoveToZombie()
    {
        Vector3 direction = zombie.transform.position - transform.position;
        direction.Normalize();
        direction.y = zombie.transform.position.y;
        transform.Translate(direction * distanceToDisplace * Time.deltaTime);
    }

    // Ejercicio 7
    void MoveToOriginalPosition() {
        Vector3 direction = originalPosition - transform.position;
        direction.Normalize();
        direction.y = transform.position.y;
        transform.Translate(direction * distanceToDisplace * Time.deltaTime);
    }
}
