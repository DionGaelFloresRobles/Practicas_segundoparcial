//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ 
//DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
/*MOVIMIENTO DEL ENEMIGO Y LA CAPACIDAD DE UBICAR AL JUGADOR COMO OBJETIVO*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{//se declaran las variables
    public Transform TARGET;
    public Transform OJITOS;
    public float VELOCIDADENEMIGO;
    
    void Start()
    {  //aqui le asignamos al target la orden de buscar por edio de una tag a nuestro player
       TARGET = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        OJITOS = GetComponent<Transform>();
    }

    //aqui se ubican los valores de la posición, transform y vectores, tambien se agrega una prueba con un debug
    void Update()
    {
        OJITOS.LookAt(TARGET.position);

        this.transform.LookAt(TARGET.position);
        float ENEMIGOPOSICION = transform.position.z;
        
        Vector3 POSICIONTOTALDELJUGADOR = TARGET.position;
        Vector3 POSICIONTOTALENEMIGO = this.transform.position;
        
        float DISTANCIAENTREOBJETOS = Vector3.Distance(POSICIONTOTALDELJUGADOR,POSICIONTOTALENEMIGO);

        //Debug.Log(POSICIONTOTALDELJUGADOR);
        //este debug dibuja una proyección de lo que sera la trayectoria o lugar de apuntado
        Debug.DrawLine(POSICIONTOTALENEMIGO,POSICIONTOTALDELJUGADOR,Color.green);

        if (DISTANCIAENTREOBJETOS > 3)
        {
            POSICIONTOTALENEMIGO = Vector3.MoveTowards(this.transform.position, TARGET.position, 10 * Time.deltaTime);
            
        }
        if (DISTANCIAENTREOBJETOS <= 3)
        {
            //con esta linea damos la orden de destrucción.
            Destroy(this.gameObject, 2f);
            //TARGET.position = POSICIONTOTALDELJUGADOR - new Vector3(0, 0, 5);
        }

    }
}
