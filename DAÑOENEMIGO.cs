//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ 
/* EL PLAYER AL COLISIONAR CON EL ENEMIGO LO DESTRUIRÁ
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAÑOENEMIGO : MonoBehaviour
{
    //se crea un vacío de collision 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //se declara que al momento de chocar con un objeto con tag de enemigo se destruye nuestro player
        if(collision.gameObject.tag == "ENEMIGO") 
        {
            Destroy(collision.gameObject); 
            this.gameObject.SetActive(false);
        }
    }
}
