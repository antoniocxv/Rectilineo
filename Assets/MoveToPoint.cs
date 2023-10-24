using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
   // Start is called before the first frame update

   public Vector3 coordenadaObjetivo; // La coordenada a la que se moverá el cilindro
   public float velocidad = 5.0f;     // Velocidad de movimiento

   private bool enMovimiento = false;


   void Start()
   {
       MoverHaciaCoordenada();
   }

   // Update is called once per frame
   void Update()
   {
       if (enMovimiento)
       {
           // Calcula la dirección hacia la coordenada objetivo
           Vector3 direccion = (coordenadaObjetivo - transform.position).normalized;

           // Calcula la distancia a la coordenada objetivo
           float distancia = Vector3.Distance(transform.position, coordenadaObjetivo);

           // Si la distancia es mayor a un umbral pequeño, sigue moviéndote
           if (distancia > 0.1f)
           {
               // Mueve el cilindro hacia la coordenada objetivo
               transform.Translate(direccion * velocidad * Time.deltaTime);
           }
           else
           {
               // El cilindro ha llegado a la coordenada objetivo
               enMovimiento = false;
               Debug.Log("El cilindro ha llegado a la coordenada objetivo.");
           }
       }
   }

   public void MoverHaciaCoordenada()
   {
       enMovimiento = true;
   }
}



