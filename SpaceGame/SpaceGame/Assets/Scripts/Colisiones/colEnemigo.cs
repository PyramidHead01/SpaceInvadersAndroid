using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colEnemigo : MonoBehaviour
{

    controladorEnemigos controladorEnemigos;
    public AudioClip clipMuerte;
    AudioSource sonMuerte;
    Text puntuacion;
    public int punt = 10;

    //vidaPlayer vidaPlayer;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        sonMuerte = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        controladorEnemigos = GameObject.FindWithTag("contrEnemigos").GetComponent<controladorEnemigos>();
        puntuacion = GameObject.FindWithTag("Puntuacion").GetComponent<Text>();
        //vidaPlayer = GameObject.FindWithTag("Player").GetComponent<vidaPlayer>(); 
        #endregion
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //vidaPlayer.vida--;
        }
        /*if (col.gameObject.tag == "BalaPlayer")
        {
            Debug.Log("asd");
            Destroy(gameObject);
        }*/
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BalaPlayer")
        {
            int.TryParse(puntuacion.text, out int puntosInt);
            puntosInt += punt;
            puntuacion.text = puntosInt.ToString();

            sonMuerte.PlayOneShot(clipMuerte);
            //controladorEnemigos.speed = controladorEnemigos.CambiarSpeed();
            controladorEnemigos.contMax = controladorEnemigos.CambiarContMax();
            Destroy(gameObject);
        }
    }

}
