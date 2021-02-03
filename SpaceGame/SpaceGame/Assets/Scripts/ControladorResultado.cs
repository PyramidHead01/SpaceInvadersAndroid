using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorResultado : MonoBehaviour
{

    vidaPlayer vidaPlayer;
    controladorEnemigos controladorEnemigos;
    Text puntuacion;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        vidaPlayer = GameObject.FindWithTag("Vida").GetComponent<vidaPlayer>();
        controladorEnemigos = GameObject.FindWithTag("contrEnemigos").GetComponent<controladorEnemigos>();
        puntuacion = GameObject.FindWithTag("Puntuacion").GetComponent<Text>();
        #endregion
    }

    void Start()
    {
        puntuacion.text = PlayerPrefs.GetInt("puntuacion").ToString();
        PlayerPrefs.SetInt("puntuacion", 0);
    }

    void Update()
    {
        if(controladorEnemigos.enemigosActuales == 11)
        {
            StartCoroutine(Victoria());
        }

        if (vidaPlayer.vida == 0)
        {
            StartCoroutine(Muerte());
        }

    }

    IEnumerator Victoria()
    {
        int.TryParse(puntuacion.text, out int puntosInt);
        PlayerPrefs.SetInt("puntuacion", puntosInt);

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Juego");

    }

    IEnumerator Muerte()
    {
        Destroy(vidaPlayer.playerInGame);
        vidaPlayer.txVidas.text = "YOU DIED";
        PlayerPrefs.SetInt("puntuacion", 0);

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Inicio");


    }

}
