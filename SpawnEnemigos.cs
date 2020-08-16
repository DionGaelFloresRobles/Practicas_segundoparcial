//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL 
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
//DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
/* SPAWN Y DESTRUCCIÓN DE ENEMIGOS*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
//variables a declarar 
    public static int contadorEnemigos;
    public Transform[] puntoOrigen;

    public int contadorVisible;
    // con la palabra damos a entender que seran los hijos emparentados, en este caso a un respawn 
    void Start()
    {
        contadorEnemigos = 0;
        puntoOrigen = new Transform[transform.childCount];
        for (int i = 0; i < puntoOrigen.Length; i++)
        {
            puntoOrigen[i] = transform.GetChild(i);
        }

    }

    // ejecución de la propiedad de destruir un enemigo cuando este tiene contacto con otro rigidbody 
    void Update()
    {
        contadorVisible = contadorEnemigos;
        if (Input.GetKeyDown(KeyCode.E))
        {

            foreach (var p in puntoOrigen)
            {
                GameObject enemigo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Destroy(enemigo.GetComponent<Collider>());


                enemigo.transform.position = p.position;

               
                    enemigo.AddComponent<EnemigoConteo>();
                    enemigo.AddComponent<Collider2D>();
                    enemigo.AddComponent<Rigidbody2D>();

               




                if (contadorEnemigos >= 5)
                {
                    Destroy(enemigo);
                }

            }


        }
    }
}
