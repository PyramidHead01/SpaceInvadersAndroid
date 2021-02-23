using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{

    public AudioClip sonDisparo;
    public GameObject balaPlayer;
    public float tMax;
    public bool player = false;
    Transform transfObj;
    AudioSource efectosSonido;
    controladorEnemigos controladorEnemigos;

    float contador = 5;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        efectosSonido = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        controladorEnemigos = GameObject.FindWithTag("contrEnemigos").GetComponent<controladorEnemigos>();
        #endregion
    }

    void Start()
    {
        transfObj = this.GetComponent<Transform>();
    }

    void Update()
    {

        contador += Time.deltaTime;

        if (contador >= tMax)
        {
            if (player)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GameObject bala = Instantiate(balaPlayer, transfObj.position, transfObj.rotation);
                    efectosSonido.PlayOneShot(sonDisparo);
                    bala.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
                    contador = 0;
                }
            }
        }

    }


    public void DispPlayer()
    {
        if (contador >= tMax)
        {
            GameObject bala = Instantiate(balaPlayer, transfObj.position, transfObj.rotation);
            efectosSonido.PlayOneShot(sonDisparo);
            bala.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            contador = 0;
        }
    }


    public void DisparoEnemigo()
    {
        GameObject bala = Instantiate(balaPlayer, new Vector3(transfObj.position.x, (transfObj.position.y - 0.1f), transfObj.position.z), transfObj.rotation);
        bala.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -10, 0);
        efectosSonido.PlayOneShot(sonDisparo);
        contador = 0;
    }

}