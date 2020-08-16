//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ 
//DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
/* Este Script funcionará para indicarle a nuestro obstaculo la sierra
que es lo que debe hacer en función al juego*/
//Descripción de usos de estos códigos:
// SE MOSTRARÁN MENSAJES EN LA PANTALLA A LA HORA DE QUE EL PLAYER REALICE CIERTAS ACCIONES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        //un letrero aprecera en caso de que nuestro personaje sea eliminado
        if (collision.gameObject.tag == "Picos")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Debug.Log("Game Over");
        }
        //instrucciones de apoyo para el jugador

        if (collision.gameObject.tag == "Plataforma")
        {

            Debug.Log("Camina Hasta la Meta para ganar el juego");
        }

        // después de haber cumplido el objetivo del nivel, en este caso una recolección un letrero de victoria aparecera en consola

        if (collision.gameObject.tag == "Final")
        {
            
            Debug.Log("HAZ GANADO!");
        }

    }
}
