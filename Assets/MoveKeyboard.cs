using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKeyboard : MonoBehaviour
{
    public float velocidadBase = 5.0f;
    public float velocidadInc = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula la dirección de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);

        // Verifica si se presiona la tecla de espacio
        if (Input.GetKey(KeyCode.Space))
        {
            // Aplica la velocidad incrementada
            movimiento = movimiento.normalized * velocidadInc * Time.deltaTime;
        }
        else
        {
            // Aplica la velocidad base
            movimiento = movimiento.normalized * velocidadBase * Time.deltaTime;
        }

        // Aplica el movimiento al objeto
        transform.Translate(movimiento);
    }
}
