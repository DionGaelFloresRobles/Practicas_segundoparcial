//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
// ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ 
/* CREACIÓN DE ARRAY PARA ENEMIGOS EN ESCENA*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROLENEMIGOS : MonoBehaviour
{
   //variables a declarar
    public static int CONTADORENEMIGOS;

    public GameObject OBJENEMIGO;
    public Transform[] SpawnPoint;

    public int TOPEENEMIGOS;
    public int INFOCANTIDADENEMIGOS;
    public bool MUERTENEIGOS;

    // les atribuimos valores a nuestras variables 
    void Start() 
    {
        CONTADORENEMIGOS = 0;
        MUERTENEIGOS = false;  
        SpawnPoint = new Transform[transform.childCount]; 
       
        for(int i = 0; i < SpawnPoint.Length; i++) 
        {
            SpawnPoint[i] = transform.GetChild(i); 
        }
        
        Invoke("Spawn",0.5f);
    }

    //se declara que la cantidad de enemigos tambien sirve para contar cuantos existen
    void Update()
    {

        INFOCANTIDADENEMIGOS = CONTADORENEMIGOS;
    }
    void spawn()
    {
           //en cada punto de spawn se genera un nuevo enemigo 
            foreach (var p in SpawnPoint)
            {
               //declaramos un tope de creación de enemigos
                GameObject ENEMIGOPOS = Instantiate(OBJENEMIGO) as GameObject;
                ENEMIGOPOS.transform.position = p.position;
                if (CONTADORENEMIGOS >= TOPEENEMIGOS)
                {
                    Destroy(ENEMIGOPOS); 
                }
            }
    }
}
