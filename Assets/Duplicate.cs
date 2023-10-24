using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5.0f; // Velocidad deseada

    public Vector3 puntoA; // Objeto que representa el punto A
    public Vector3 puntoB; // Objeto que representa el punto B

    // Update is called once per frame
    void Update()
    {
        if (puntoA != null && puntoB != null)
        {
           
            // Calcula el vector de dirección de A a B
            Vector3 goal = puntoA - puntoB;

            // El vector 'direccion' ahora contiene la dirección desde A hacia B
            Debug.Log("Vector de dirección: " + goal);

            if(goal != null )
            {
                // Normaliza el vector de dirección
                Vector3 direction = goal.normalized;

                // Multiplica por la velocidad
                Vector3 movement = direction * speed * Time.deltaTime;

                // Mueve el objeto en la dirección normalizada y con velocidad constante
                this.transform.Translate(goal.normalized * speed * Time.deltaTime);
            }
        }
        else
        {
            Debug.LogError("Asegúrate de asignar los objetos Transform de puntoA y puntoB en el Inspector.");
        }
    }
   
   
 
}
