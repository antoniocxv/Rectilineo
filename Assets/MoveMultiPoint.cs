
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveMultiPoint : MonoBehaviour
{


    // Array de puntos en el plano a visitar
    public Vector3[] targetPoints;

    // Velocidad de movimiento del objeto
    public float speed = 5f;

    // Índice del punto actual
    private int currentTargetIndex = 0;
    private bool realizarAccion = true;

    void Update()
    {

        if (realizarAccion)
        {

            if (targetPoints.Length == 0)
            {
                Debug.LogWarning("No se han definido puntos en el plano.");
                return;
            }

            // Obtiene el punto de destino actual
            Vector3 currentTarget = targetPoints[currentTargetIndex];

            // Calcula la dirección hacia el objetivo
            Vector3 direction = currentTarget - transform.position;

            // Comprueba si el objeto ha llegado al punto de destino actual
            if (direction.magnitude < 0.1f)
            {
                // Cambia al siguiente punto en el arreglo
                currentTargetIndex = (currentTargetIndex + 1) % targetPoints.Length;
                if (currentTargetIndex == 0) { SiguientePunto(); }
            }
            else
            {
                // Normaliza la dirección para mantener una velocidad constante
                direction.Normalize();

                // Mueve el objeto hacia el punto de destino
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }


    }

    void SiguientePunto()
    {
        // Activa la bandera para realizar la acción en el siguiente Update()
        realizarAccion = false;
    }
    // Start is called before the first frame update
   
}




