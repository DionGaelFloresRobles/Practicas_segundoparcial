//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS 
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
/*CREACIÓN DE NUEVA ESCENA O NIVEL*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
//biblioteca nueva de escenas en unity

public class NewBehaviourScript : MonoBehaviour
{
    [Tooltip("ESTA VARIABLE ME AYUDA A DEFINIR EL NUMERO DE ESCENA A CARGAR")]
//variables a declarar
    public int NUMERODEESCENA;
    public int CANTIDADENEMIGOS;
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.tag == "PLAYER")
    //    {
    //        SceneManager.LoadScene(NUMERODEESCENA); //QUE NUMERO DE ESCENA SE USARA AL COLISIONAR CON ESTE TRIGGER
    //    }
    //}
    private void Update()
    { //condicionar si la cantidad es mayor, menor o igual a cero
        if(CANTIDADENEMIGOS <= 0)
        {
            StartCoroutine("ESPERA");
        }
        if (Input.GetKeyDown(KeyCode.Y)) 
        {
            CANTIDADENEMIGOS--;
        }
    }
    //activar un gatillo con colliders 2D
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //collision del jugador
        if(collision.gameObject.tag == "Player") 
        {

        }
    }
    IEnumerator ESPERA()
    { //tiempo que transcurre para colisionar
        yield return new WaitForSeconds(5f);
        //tiempo entre cambio de escena
        SceneManager.LoadScene(NUMERODEESCENA); 
        yield return null;
    }
}
