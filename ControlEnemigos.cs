using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ControlEnemigos : MonoBehaviour
{

    public static int contadorenemigos;

    public GameObject objenemigo;

    public Transform[] spawnpoint;

    public int infocantidadenemigos;
    // Start is called before the first frame update
    void Start()
    {
        contadorenemigos = 0;
        spawnpoint = new Transform[transform.childCount];
        for (int i = 0; i < spawnpoint.Length; i++) ;
        {
            spawnpoint[1] = transform.GetChild(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        infocantidadenemigos = contadorenemigos;
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach(var p in spawnpoint)
            GameObject enemigopos = Instantiate(objenemigo) as GameObject;
            //enemigopos.transform.position = spawnpoint.position;
            if (contadorenemigos >= 5)
            {
                Destroy(enemigopos);
            }
        }
    }
}
