//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
  // ASIGNATURA: ESTRUCTURA DE DATOS 
  //DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
  /* Este Script funcionará para abrir puertas mediante triggers*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AbrirPuerta : MonoBehaviour
{
    //declaración de variables
    [SerializeField]
    PlayerControl playervida;

    // inicialización, ubicación deol jugador y cuanto se le restara de vida a nuestro personaje
    {
       playervida=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }
    private void OnTriggerEnter2D (Collider2D collision)
{
    if (collision.gameObject.tag=="Player")
    {
        playervida.Vida--;

    }

}

}
