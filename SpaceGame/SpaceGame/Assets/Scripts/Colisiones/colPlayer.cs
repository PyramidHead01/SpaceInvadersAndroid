using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colPlayer : MonoBehaviour
{

    public AudioClip clipMuerte;
    AudioSource sonMuerte;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        sonMuerte = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
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
        Destroy(gameObject);
    }

}
