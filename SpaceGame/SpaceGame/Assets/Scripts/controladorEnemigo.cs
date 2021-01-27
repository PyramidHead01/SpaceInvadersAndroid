using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorEnemigo : MonoBehaviour
{
    //Variables que uso
    #region Variables
    Transform posEnemgios;
    controladorEnemigos controladorEnemigos;
    public float speed = 0.4f;
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

            speed = CambiarSpeed();

            //Si la variable de movimientoPos es true, los aliens se moveran hacia la derecha, y en el caso de que sea false, sera hacia la izquierda
            #region MovimientoEnemigos
            if (controladorEnemigos.movimientoPos)
            {
                this.transform.position = new Vector3(this.transform.position.x + speed, this.transform.position.y, this.transform.position.z);
            }
            else
            {
                Debug.Log("ASASDASDQWEQ");
                this.transform.position = new Vector3(this.transform.position.x - speed, this.transform.position.y, this.transform.position.z);
            }
            #endregion


            contador = 0;
        }





    }

    float CambiarSpeed()
    {
        if (controladorEnemigos.enemigosActuales == controladorEnemigos.enemigosTotales || controladorEnemigos.enemigosActuales+1 == controladorEnemigos.enemigosTotales)
            return 1;

        float num = 1 / controladorEnemigos.enemigosTotales;

        num *= (controladorEnemigos.enemigosActuales + 1);

        return num;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Si colisiona con  la pared derecha, el movimiento pasa a ir a la izquierda, y viceversa con la pared izquierda, al acabar, bajan un poco
        #region Paredes
        if (collision.gameObject.tag == "ParDer")
        {
            controladorEnemigos.movimientoPos = false;

            posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.5f, posEnemgios.position.z);

            /*if (!controladorEnemigos.movimientoPos)
            {
                controladorEnemigos.movimientoPos = false;
                posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.5f, posEnemgios.position.z);
                //this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y - 0.5f, this.transform.position.z);
            }

            else
            {
                controladorEnemigos.movimientoPos = true;
                posEnemgios.position = new Vector3(posEnemgios.position.x , posEnemgios.position.y - 0.5f, posEnemgios.position.z);
                //this.transform.position = new Vector3(this.transform.position.x + 0.1f, this.transform.position.y - 0.5f, this.transform.position.z);
            }*/
        }

        if (collision.gameObject.tag == "ParIzqu")
        {

            controladorEnemigos.movimientoPos = true;

            posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.5f, posEnemgios.position.z);

            /*if (!controladorEnemigos.movimientoPos)
            {
                controladorEnemigos.movimientoPos = false;
                posEnemgios.position = new Vector3(posEnemgios.position.x, posEnemgios.position.y - 0.5f, posEnemgios.position.z);
                //this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y - 0.5f, this.transform.position.z);
            }

            else
            {
                controladorEnemigos.movimientoPos = true;
                posEnemgios.position = new Vector3(posEnemgios.position.x , posEnemgios.position.y - 0.5f, posEnemgios.position.z);
                //this.transform.position = new Vector3(this.transform.position.x + 0.1f, this.transform.position.y - 0.5f, this.transform.position.z);
            }*/
        }

        #endregion

    }
}
