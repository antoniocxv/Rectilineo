using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToObjetive : MonoBehaviour
{
    public Transform goal; // El cilindro que es el objetivo
    public float speed = 4.0f; // Velocidad de movimiento
    

    void Start()
    {
        // Girar hacia el objetivo
        this.transform.LookAt( goal.position);
    }

    void Update()
    {

        

        // Calcular la dirección en la que se va a mover el cubo
        Vector3 direction = (goal.position - transform.position).normalized;

        // Dibuja una línea de depuración para verificar la dirección
        Debug.DrawRay(transform.position, direction*4, Color.red);


        // Mover el cubo en la dirección hacia el objetivo en el sistema de referencia del mundo
        this.transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
