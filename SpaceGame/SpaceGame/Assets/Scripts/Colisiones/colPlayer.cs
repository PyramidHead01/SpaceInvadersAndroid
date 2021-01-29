using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colPlayer : MonoBehaviour
{

    public AudioClip clipMuerte;
    AudioSource sonMuerte;
    vidaPlayer vidaPlayer;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        sonMuerte = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        vidaPlayer = GameObject.FindWithTag("Player").GetComponent<vidaPlayer>();
        #endregion
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (/*col.gameObject.tag == "Enemigo" ||*/ col.gameObject.tag == "BalaEnemigo")
        {
            Muerte();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemigo")
        {
            Muerte();
        }
    }

    void Muerte()
    {
        sonMuerte.PlayOneShot(clipMuerte);
        vidaPlayer.vida--;
        //Destroy(gameObject);
    }

}
