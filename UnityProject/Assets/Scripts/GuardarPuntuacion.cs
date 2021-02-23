using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarPuntuacion : MonoBehaviour
{

    public Text puntText;

    // Update is called once per frame
    void Update()
    {
        puntText.text = PlayerPrefs.GetInt("PuntuacionTotal").ToString() + " puntos totales";
    }

}
