//NOMBRE DEL DESARROLLADOR: FLORES ROBLES DION GAEL
//ESTRUCTURA DE DATOS
//PROFESOR JOSUE ISRAEL RIVAS DIAZ
/* DESTRUCCIÓN MEDIANTE ALGO QUE CUMPLE LA FUNCIÓN DE BALA*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{ // se indica que se destruira la bala cuando se invoca 
    private void OnEnable()
    {
        Invoke("Destroy", 2f);
    }
    //indica que se destruira cuando cumpla su función mediante un float
    private void Destroy()
    {
        this.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

   
}
