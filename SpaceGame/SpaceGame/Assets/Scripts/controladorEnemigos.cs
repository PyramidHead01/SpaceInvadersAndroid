using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorEnemigos : MonoBehaviour
{

    public bool movimientoPos = true;
    public int enemigosTotales = 55, enemigosActuales;
    public float speed = 0.5f, probabilidad = 0.99f, p = 0.99f;

    void Awake()
    {
        enemigosActuales = enemigosTotales;
    }

    public float CambiarSpeed()
    {

        enemigosActuales--;

        if (enemigosActuales == enemigosTotales)
            return speed;

        //Quizas ajustar la velocidad despues???
        return ((speed * enemigosTotales) / enemigosActuales);

    }

    public float CalcularProbabilidad()
    {

        if (enemigosActuales == enemigosTotales)
            return probabilidad;

        return ((p * enemigosActuales) / enemigosTotales);

    }


}
