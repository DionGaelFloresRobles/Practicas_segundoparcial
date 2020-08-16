//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ 
//DESCRIPCIÓN DE USOS DE ÉSTE CÓDIGO:
/*PROYECCIÓN DE UNA TRAYECTORIA DE DISPARO MEDIANTE UN RAY*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//aqui arriba se agrega una nueva libreria de UI
//variables a utilizar 
public class DISPARORAYO : MonoBehaviour
{
    //variables declaradas
    public float DISTANCIARAYO;
    public LayerMask CAPADAÑO;
    public Transform BARRIL;
    public Image PUNTERO;

    private Ray RAYO;
    private Ray RAYOINTERACCION;
    private Vector2 CENTROCAMARA; 
    private RaycastHit HITINFO;
    void Start()
    {
        //division de las pantallas en x y y más una opción de esconder el cursor en el área de uso
        this.CENTROCAMARA.x = Screen.width / 2; 
        this.CENTROCAMARA.y = Screen.height / 2; 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    
    void Update()
    { //posición desde donde saldrá el rayo y en que dirección 
        RAYO.origin = BARRIL.position;
        RAYO.direction = BARRIL.forward;
        RAYOINTERACCION = Camera.main.ScreenPointToRay(this.CENTROCAMARA);//array con divisiones de la pantalla 

        //representación visual del rayo 
        Debug.DrawRay(RAYOINTERACCION.origin, RAYOINTERACCION.direction * DISTANCIARAYO, Color.green); 
        //se especifica el movimiento dentro de if anidados 
        if (Physics.Raycast(RAYOINTERACCION,out HITINFO, CAPADAÑO))
        {
            if (HITINFO.collider != null)
            {
                if(HITINFO.collider.tag == "ENEMY")
                {
                    //al momento que se cruza en la mirilla este en automatico se pone en color verde
                    PUNTERO.color = Color.green; 
                }
            }
        }
        else
        { //mientras no se apunte a ningun enemigo este se quedara en su color original 
            PUNTERO.color = Color.white; 
        }

        if (Input.GetMouseButtonDown(0))
        { //aquí en caso de que choque hitinfo
            if (Physics.Raycast(RAYO, out HITINFO, DISTANCIARAYO,CAPADAÑO))
            { //rayo collider
                if (HITINFO.collider != null)
                {
                    //Debug.Log("ME DISTE"); //el mensaje que se desplegara en consola
                    if (HITINFO.collider.tag == "ENEMY") 
                    {
                        Destroy(HITINFO.collider.gameObject);
                    }
                }
            }
        }
    }
}
