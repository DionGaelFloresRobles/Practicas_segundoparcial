//Nombre del desarrollador: Dion Flores
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 * Este script se funcionara para simular la destrucción de un objeto al ser colisionado por otro
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{  
    //dar a entednder el tiempo
    [SerializeField]
    float cronometro = 0.0f;
    //Le damos forma logica al sprite que ocupa nuestro player
    [SerializeField]
    SpriteRenderer spritepared;
    //dar vida al personaje
    [SerializeField]
    PlayerControl playerlife;

    private void Start()
    {
        //tiene como objetivo buscar un gameobject en el programa
        //spritepared =GameObject.Find("pared_1").GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)//mecánica núcleo
    {
        //******Bloque 1 registra colision y evento a activarse con un objeto pared 
        if(collision.gameObject.tag == "pared")
        {
            //leeme de tus propiedades 
            spritepared.material.color = Color.blue;
            //Destroy(collision.gameObject);
            //Destroy(this.gameObject);
        }
        //******Bloque 2 Registra colision y evento a activarse con un objeto Player
        if (collision.gameObject.tag == "Player")
        {
            playerlife.life--;
            if (playerlife.life <= 0)
            {
                playerlife.spritePlayer.enabled = false;
            }
            Debug.Log("al infinito y mas alla");
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    { 
         //********bloque aislado**********
        if (collision.gameObject.tag == "pared")//localización de un objeto y los almaceno en collision.gameobject
        {   //debug comprobar
            //Dar acción en tiempo real para aumentar el gamefeel
            cronometro = cronometro + 0.5f * Time.deltaTime;
            //cronometro +=0.5f;
            //*********bloque aislado 2********
            if(cronometro >= 5.0f)
            {
                cronometro = 5.0f;

                if (cronometro == 5.0f)
                {
                    Destroy(collision.gameObject);
                    Destroy(this.gameObject);//ojo con lo que se destruye, por que las acciones posteriores no funcionaran
                }
            }
            //********************************
        }
        //********************************
    }







}
