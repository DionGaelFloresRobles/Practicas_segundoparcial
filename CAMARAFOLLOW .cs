//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
// HAREMOS QUE LA CAMARA SEA GUIDA POR EL JUGADOR EN EJES Y Z.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMARAFOLLOW : MonoBehaviour
{
    //declaración de variables
    public Transform target;
    public Vector3 puntoInicial;
    //posición del objetivo
    void Start()
    {
      
        puntoInicial = transform.position - target.position;
    }

    void Update()
    {
       //se ejecutan los vectores y solo ex y y estan desbloqueados para el libre movimiento de la cámara
        transform.position = new Vector3(Mathf.Clamp(target.position.x, 0.44f,27f), Mathf.Clamp(target.position.y,-2.7f,35f), transform.position.z);
    }
}
