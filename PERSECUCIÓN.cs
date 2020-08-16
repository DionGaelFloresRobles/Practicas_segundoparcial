//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ 
//PERSECUCIÓN DE JUGADOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecucionLinea : MonoBehaviour

{
    //se declara la variable de objetvo
    public Transform target;

    void Start()
    {
        //se da la orden a quien perseguir
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {
        //indicación para un movimiento recto del enemigo
        transform.position = Vector2.MoveTowards(transform.position, target.position, 3f * Time.deltaTime);

        
    }
}
