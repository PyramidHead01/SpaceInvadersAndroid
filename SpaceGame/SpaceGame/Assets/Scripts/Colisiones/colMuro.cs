using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colMuro : MonoBehaviour
{

    public AudioClip clipMuro;
    AudioSource sonMuro;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        sonMuro = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        #endregion
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BalaEnemigo" || col.gameObject.tag == "BalaPlayer")
        {
            sonMuro.PlayOneShot(clipMuro);
            Destroy(gameObject);
        }
    }

}
