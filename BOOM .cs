//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
/*DESTRUCCIÓN DE UN OBJETO AL COLISIONAR CON OTRO.
  */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
//se declaran las variables
    [SerializeField]
     float Cronometro = 0.0f; 
    [SerializeField]
    SpriteRenderer SpritePared; 
    [SerializeField]
    PlayerControl PlayerVida; 
   
    private void start()
    {
        //BUSCAR PARED
        SpritePared = GameObject.Find("PARED").GetComponent<SpriteRenderer>();
    }
    //INDICAMOS COLISIÓN
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //EXISTIRÁ UNA COLISIÓN AL TOCAR PARED 
        if (collision.gameObject.tag == "PARED")
        {
            //SE INDICA DE QUE COLOR SE CAMBIARÁ LA PARED AL TOCAR CON EL OBJETO
            SpritePared.material.color = Color.blue;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        //COLISION Y EVENTO AL ACTIVARSE CON PLAYER
        if(collision.gameObject.tag== "Player")
        {
            //INDICACIÓN DE LO QUE SUCEDERÁ A LA VITA (RESTARÁ)
            PlayerVida.VIDA--;
            //Debug.Log("al infinito y mas haya"); //APARECERÁ EN CONSOLA LA FRASE AL COLISIONAR
        }
    }

    //se localiza el objeto, se multiplica por delta time para mejor refresco de fps  y se le limita con un tiempo para destruirse
    
    private void OnCollisionStay2D(Collision2D collision)   
        {
        if (collision.gameObject.tag == "PARED")
        {
            Cronometro= Cronometro + 0.5f * Time.deltaTime;
            if (Cronometro >= 5.0f) 
            {
                Cronometro = 5.0f;
                if (Cronometro == 5.0f)
                {
                    Destroy(collision.gameObject);
                    Destroy(this.gameObject);
                }
            }
        }
         
    }
}
