using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public int puntuacion = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cilindro"))
        {
            // Acceder al cilindro con el que colisionamos
            GameObject cilindro = collision.gameObject;

            // Cambiar el color del cilindro a rojo (asumiendo que tiene un material)
            Renderer cilindroRenderer = cilindro.GetComponent<Renderer>();
            
            if (cilindroRenderer.material.color != Color.red)
            {
                cilindroRenderer.material.color = Color.red;

              // Aumentar la puntuación del jugador
                this.puntuacion = this.puntuacion + 100;
                Debug.Log("Puntuación: " + this.puntuacion);

            }
            else
            {
                Debug.Log("Ve por otro que este ya te puntuó: ");
            }
            

            // Puedes desactivar el cilindro si ya no es necesario
            // cilindro.SetActive(false);
        }
    }
}
