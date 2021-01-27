using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colEnemigo : MonoBehaviour
{

    controladorEnemigos controladorEnemigos;
    public AudioClip clipMuerte;
    AudioSource sonMuerte;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        sonMuerte = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        controladorEnemigos = GameObject.FindWithTag("contrEnemigos").GetComponent<controladorEnemigos>();
        #endregion
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {

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
            sonMuerte.PlayOneShot(clipMuerte);
            controladorEnemigos.enemigosActuales--;
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
