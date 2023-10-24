using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    public Transform objetivo;  // El objeto que la cámara seguirá
    public Vector3 offset = new Vector3(0, 2, -5);  // Desplazamiento relativo entre la cámara y el objeto
    public float suavidad = 5.0f;  // Suavidad del seguimiento

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Calcula la posición deseada de la cámara
            Vector3 posicionDeseada = objetivo.position + offset;

            // Interpola suavemente la posición actual de la cámara hacia la posición deseada
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavidad * Time.deltaTime);
        }
    }
}
