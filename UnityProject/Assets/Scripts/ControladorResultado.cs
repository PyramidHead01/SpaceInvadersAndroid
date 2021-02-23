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

    public Text vida;
    public Image[] imgVidas;

    AudioSource son;
    public AudioClip victSon, derrSon;

    void Awake()
    {
        //Le doy a las variables los compontes respectivos
        #region AsignarVariables
        son = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
        vidaPlayer = GameObject.FindWithTag("Vida").GetComponent<vidaPlayer>();
        controladorEnemigos = GameObject.FindWithTag("contrEnemigos").GetComponent<controladorEnemigos>();
        puntuacion = GameObject.FindWithTag("Puntuacion").GetComponent<Text>();
        #endregion
    }

    void Start()
    {
        puntuacion.text = PlayerPrefs.GetInt("puntuacion").ToString();
        //PlayerPrefs.SetInt("puntuacion", 0);
    }

    void Update()
    {
        if(controladorEnemigos.enemigosActuales <= 0)
        {
            StartCoroutine(Victoria());
        }

        if (vidaPlayer.vida == 0)
        {

            StartCoroutine(Muerte());
            vidaPlayer.vida = -1;
        }

    }

    IEnumerator Victoria()
    {

        float victSonDur = victSon.length;
        son.PlayOneShot(victSon);
        victSon = null;
        DarPuntos();

        yield return new WaitForSeconds(victSonDur + 0.5f);

        SceneManager.LoadScene("Juego");

    }

    void DarPuntos()
    {

        int.TryParse(puntuacion.text, out int puntosInt);
        PlayerPrefs.SetInt("puntuacion", puntosInt);
    }

    IEnumerator Muerte()
    {
        DarPuntos();
        float derrSonDur = derrSon.length;
        son.PlayOneShot(derrSon);
        //derrSon = null;

        vidaPlayer.txVidas.text = "0";

        //PlayerPrefs.SetInt("PuntuacionTotal", 0);


        int puntTot = PlayerPrefs.GetInt("PuntuacionTotal");
        Debug.Log("Puntos guardados: " + puntTot);
        int punt = PlayerPrefs.GetInt("puntuacion");

        Debug.Log("Puntos de partida " + punt);

        int puntFin = puntTot + punt;

        Debug.Log("Puntos finales: " + puntFin);

        PlayerPrefs.SetInt("PuntuacionTotal", puntFin);
        //PlayerPrefs.SetInt("PuntuacionTotal", 0);
        //Debug.Log(PlayerPrefs.GetInt("puntuacion"));
        PlayerPrefs.SetInt("puntuacion", 0);


        foreach (Image vid in imgVidas)
        {
            Destroy(vid);
        }

        Destroy(vidaPlayer.playerInGame);




        yield return new WaitForSeconds(derrSonDur);

        SceneManager.LoadScene("Inicio");


    }

}