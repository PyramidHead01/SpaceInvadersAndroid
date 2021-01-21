using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorEnemigo : MonoBehaviour
{
    //Variables que uso
    #region Variables
    Transform posEnemgios;
    controladorEnemigos controladorEnemigos;
    float speed = 1.5f;
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

        //Si la variable de movimientoPos es true, los aliens se moveran hacia la derecha, y en el caso de que sea false, sera hacia la izquierda
        #region MovimientoEnemigos
        if (controladorEnemigos.movimientoPos)
        {
            this.transform.position = new Vector3(this.transform.position.x + (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
        else
        {
            this.transform.position = new Vector3(this.transform.position.x - (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
        #endregion



    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Si colisiona con  la pared derecha, el movimiento pasa a ir a la izquierda, y viceversa con la pared izquierda, al acabar, bajan un poco
        //Quizas seria mejor que fuese solo un objeto el de la colision y que invierta la posicion de la variable
        #region Paredes
        if (collision.gameObject.tag == "ParedDer")
        {
            controladorEnemigos.movimientoPos = false;
            posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - speed, posEnemgios.position.z);
        }
        else if (collision.gameObject.tag == "ParedIzq")
        {
            controladorEnemigos.movimientoPos = true;
            posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - speed, posEnemgios.position.z);
        }
        #endregion

        //Si colisiona con las bala del player...

    }
}
