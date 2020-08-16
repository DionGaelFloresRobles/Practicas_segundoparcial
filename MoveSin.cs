//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
//DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
/* //LA FUNCIÓN DE ESTE SCRIPT SERA INDICAR INFORMACION ESPECIFICA DE ENEMIGOS*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//variables declaradas 
public class MoveSin : MonoBehaviour
{
    public Transform[] enemigo;

   public Vector3[] puntoOrigen;

    public float velocidadTraslado;
    public float amplitud;


    void Start()
    { //posiciones y enemigos en escena
        puntoOrigen = new Vector3[3];

        //puntoOrigen[0] = enemigo[0].position;
        //puntoOrigen[1] = enemigo[1].position;
        //puntoOrigen[2] = enemigo[2].position;

        for (int i = 0; i < puntoOrigen.Length; i++)
        {
            puntoOrigen[i] = enemigo[i].position;
        }
    }

     //aquí se ejecuta el valor de posición y movimiento del enemigo.
    void Update()
    {
        Vector3 mateSeno = new Vector3(Mathf.Sin(Time.time * velocidadTraslado) * amplitud, 0, 0);

        for (int i = 0; i < enemigo.Length; i++)
        {
            enemigo[i].position = puntoOrigen[i] + mateSeno;
          
        }

    }
}
