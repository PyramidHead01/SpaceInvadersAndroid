using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorEnemigo : MonoBehaviour
{
    //Variables que uso
    #region Variables
    Transform posEnemgios;
    controladorEnemigos controladorEnemigos;
    float contador = 0;
    #endregion

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        controladorEnemigos = GameObject.FindWithTag("contrEnemigos").GetComponent<controladorEnemigos>();
        posEnemgios = GameObject.FindWithTag("contrEnemigos").GetComponent<Transform>();
        #endregion
    }

    void Update()
    {

        contador += Time.deltaTime;

        if (contador >= 1)
        {

            //speed = 0.5f;

            //Si la variable de movimientoPos es true, los aliens se moveran hacia la derecha, y en el caso de que sea false, sera hacia la izquierda
            #region MovimientoEnemigos
            if (controladorEnemigos.movimientoPos)
            {
                this.transform.position = new Vector3(this.transform.position.x + controladorEnemigos.speed, this.transform.position.y, this.transform.position.z);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x - controladorEnemigos.speed, this.transform.position.y, this.transform.position.z);
            }
            #endregion


            contador = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Si colisiona con  la pared derecha, el movimiento pasa a ir a la izquierda, y viceversa con la pared izquierda, al acabar, bajan un poco
        #region Paredes
        if (collision.gameObject.tag == "ParDer")
        {
            controladorEnemigos.movimientoPos = false;

            //posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.5f, posEnemgios.position.z);

        }

        if (collision.gameObject.tag == "ParIzqu")
        {

            controladorEnemigos.movimientoPos = true;

            //posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.5f, posEnemgios.position.z);

        }

        if (collision.gameObject.tag == "ParIzqu" || collision.gameObject.tag == "ParDer")
        {
            posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.1f, posEnemgios.position.z);
        }

        #endregion

    }
}
