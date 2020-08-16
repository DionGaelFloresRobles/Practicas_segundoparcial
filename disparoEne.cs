//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
//DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
/* //LA FUNCIÓN DE ESTE SCRIPT SERA CONTINUAR CON LOS DISPAROS PERO UNICAMENTE DE ENEMIGOS 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEne : MonoBehaviour
{
// variables a declarar
    [SerializeField] Rigidbody2D proyectil;
    [SerializeField] Transform[] bocaCañon;
    [SerializeField] float fuerzaDisparo;
    float disparoAletorio;


    // se inicializa el disparo con un rango establecido del enemigo
    void Start()
    {
        disparoAletorio = Random.Range(0.5f, 5f);
        InvokeRepeating("Shoot", 0.5f, disparoAletorio);
    }

    // se ejecuta el disparo como un rigid body que ocasiona daño 
    void Shoot()
    {
        foreach (var bC in bocaCañon)
        {
            var proyectilPos = Instantiate(proyectil) as Rigidbody2D;

            proyectilPos.transform.position = bC.position;

            proyectilPos.AddForce(bC.right * fuerzaDisparo);
        }
       
    }
}
