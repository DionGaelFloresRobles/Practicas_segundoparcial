using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSeno : MonoBehaviour
{          //array   ID
    public string[] nombrejugadores;
    [SerializeField]
    Transform[] snowman;

    [SerializeField]
    Vector3[] posicioninicial;

    public float velocidad;

    public float extension;

    // Start is called before the first frame update
    void Start()
    {   //indice
        nombrejugadores = new string[6] { "Josue", "Pedro", "Hugo", "Mcpato", "Luis", "Paco" };

        posicioninicial = new Vector3[snowman.Length];
        //posicioninicial[0] = snowman[0].position;
        //posicioninicial[1] = snowman[1].position;
        //posicioninicial[2] = snowman[2].position;

        for (int i = 0; i < snowman.Length; i++)
        {
            posicioninicial[i] = snowman[i].position;
        }


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 senopos = new Vector3(Mathf.Sin(Time.time * velocidad) * extension, 0, 0);

        for (int i = 0; i < snowman.Length; i++)
        {
            snowman[i].position = posicioninicial[i] + senopos;
        }
    }
}
