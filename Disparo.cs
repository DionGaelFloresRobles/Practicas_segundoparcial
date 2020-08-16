//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
//SERVIRA PARA REALIZAR DISPAROS DE BALAS MEDIANTE CAÑON
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{// declaración de variables
    [SerializeField]
    Transform[] cañon;
    [SerializeField]
    Rigidbody2D bala;

    private void Start()
    {
        //se inicializan datos especificos declarados aquí
        InvokeRepeating("Shoot", 0.5f,1.0f);
    }

    // añadimos rigidbody, fuerza y ejecución del disparo 
    void Shoot()
    {
        foreach (var c in cañon)
        { 
                    Rigidbody2D balaPos = Instantiate(bala) as Rigidbody2D;
                    balaPos.transform.position = c.position;
                    balaPos.AddForce(c.right * -1000);
                    
        }      
    }

}
