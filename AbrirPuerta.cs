//Nombre del desarrollador: Dion Flores
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 * Este script se utilizará para crear la acció de tener unobjeto e interactuar con el pero no de manera física, lo que puedo generar energía para salud
 o quitar energía
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    [SerializeField]
    PlayerControl playerlife;

    // Start is called before the first frame update
    void Start()
    { //declaracion de nuestro gameobject player
        playerlife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {    //aquí dejamos claro que una colisión le resta vida al jugador
        if (collision.gameObject.tag =="Player")
        {
            playerlife.life--;
            Destroy(this.gameObject);
            //Debug.Log("la puerta esta abierta");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {   //con esta línea dejamos en claro que cuando el player llegue a cero su sprite desaparezca
        if (collision.gameObject.tag == "Player")
        {
            playerlife.life--;
        }
    }

}
 