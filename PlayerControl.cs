//Nombre del desarrollador: Dion Flores
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 * Este script se utilizara´para generar el control del avatar jugador
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{//inicio del cuerpo de la clase

    //++++++área para declarar variable

    //el tipo de dato  nombre de la variable
    Rigidbody2D fisicasRB2D;
    //al declarar una variable como publica se puede visualizar en el inspector
    public float fuerzasaltopersonaje;

    //declaración de una variable vida
    public int life;

     //cumple con el muestreo en el inspector pero mantiene el acceso privado
   [SerializeField]
    float velocidadPersonaje;

    //variable de nuestro sprite
    public SpriteRenderer spritePlayer;

    //+++++++++++++++++++++++++++++++++

    // Start sirve para inicializar datos, componentes y variables
    //carga todos mis GameObject, componente, acciones, valores o eventos
    // al juego
    void Start()
    {
        fisicasRB2D = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        fuerzasaltopersonaje = 5.0f;
        velocidadPersonaje = 1.0f;
        life = 3;
        
       
    }

    // sirve para utilizar los datos de los componenetes y variables
    void Update()
    {
        //voy a usar una entrada(input)utilizo el operador punto para entrar en sus
        //propiedades y elijo una entrada de la tecla presionada
        //le indico que va representar en el mundo real esta entrada
        if (Input.GetKeyDown(KeyCode.Space))
        {   //variable a utilizar, agrega una fuerza,
            //dirección en que agrega esa fuerza la magnitud con que aplicara la fuerza
            //agregar o traducir a un impulso
            fisicasRB2D.AddForce(Vector2.up * fuerzasaltopersonaje, ForceMode2D.Impulse);
        }

        // voy usar una entrada input getkey para el movimiento a izquierda y derecha de personaje
        if (Input.GetKey(KeyCode.RightArrow))
        {//cambiar la velocidad del personaje de 0 a 1 en x//lee y manten el valor actual de velocidad en y
            fisicasRB2D.velocity = new Vector2(velocidadPersonaje, fisicasRB2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            fisicasRB2D.velocity = new Vector2(-velocidadPersonaje, fisicasRB2D.velocity.y);

        }
        // este es el que detona la acción de desaparecer el render al momento de llegar a 0 de vida.
        if (life <= 0)
        {
            spritePlayer.enabled = false;
        }









    }
}//fin del cuerpo de la clase
