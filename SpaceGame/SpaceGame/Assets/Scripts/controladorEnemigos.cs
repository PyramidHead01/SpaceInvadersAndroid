using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorEnemigos : MonoBehaviour
{

    public disparar[] disparar;
    float contador = 0;
    public float tMax;
    public bool movimientoPos = true;
    public int enemigosTotales = 55, enemigosActuales;
    public float speed = 0.5f;

    void Awake()
    {
        enemigosActuales = enemigosTotales;
    }

    void Update()
    {

        contador += Time.deltaTime;

        if (contador >= tMax)
        {
            PosibilidadDisparo();
            contador = 0;
        }

    }

    public float CambiarSpeed()
    {

        enemigosActuales--;

        if (enemigosActuales == enemigosTotales || speed >= 1.7f)
            return speed;

        //Quizas ajustar la velocidad despues???
        return ((speed * enemigosTotales) / enemigosActuales);

    }

    public void PosibilidadDisparo()
    {

        int j = -1, x = -1;

        do
        {
            j = Random.Range(0, enemigosTotales - 1);
            if(speed > 1)
                x = Random.Range(0, enemigosTotales - 1);
        } while (j == x);


        for (int i = 0; i < enemigosActuales; i++)
        {

            if (j == -1 && x == -1)
                break;

            try
            {
                if(i == j)
                {
                    disparar[j].DisparoEnemigo();
                    j = -1;
                }
                if (i == x && speed > 1)
                {
                    disparar[x].DisparoEnemigo();
                    x = -1;
                }
            }
            catch (MissingReferenceException)
            {
                PosibilidadDisparo();
            }
            catch (System.ArgumentOutOfRangeException)
            {
            PosibilidadDisparo();
            }
        }
    }
}
