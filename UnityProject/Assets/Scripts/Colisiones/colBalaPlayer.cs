using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colBalaPlayer : MonoBehaviour
{

    public AudioClip clipBala;
    AudioSource sonChoqueBala;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        sonChoqueBala = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        #endregion
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "BalaEnemigo" || col.gameObject.tag == "Muro")
        {
            sonChoqueBala.PlayOneShot(clipBala);
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Enemigo" || col.gameObject.tag == "SueloTecho")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
