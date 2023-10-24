using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    public Transform objetivo;  // El objeto que la c�mara seguir�
    public Vector3 offset = new Vector3(0, 2, -5);  // Desplazamiento relativo entre la c�mara y el objeto
    public float suavidad = 5.0f;  // Suavidad del seguimiento

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Calcula la posici�n deseada de la c�mara
            Vector3 posicionDeseada = objetivo.position + offset;

            // Interpola suavemente la posici�n actual de la c�mara hacia la posici�n deseada
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavidad * Time.deltaTime);
        }
    }
}
