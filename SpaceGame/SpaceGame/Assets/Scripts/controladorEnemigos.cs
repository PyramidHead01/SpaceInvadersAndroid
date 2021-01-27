using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorEnemigos : MonoBehaviour
{

    public bool movimientoPos = true;
    public int enemigosActuales, enemigosTotales;

    // Start is called before the first frame update
    void Start()
    {
        enemigosTotales = enemigosActuales + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
