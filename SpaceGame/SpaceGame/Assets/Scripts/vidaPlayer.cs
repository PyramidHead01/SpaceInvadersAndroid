using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaPlayer : MonoBehaviour
{

    public int vida = 3;
    int vidaAnt = 3;
    public Image[] imgVidas;
    public Text txVidas;
    public GameObject playerInGame;
    public GameObject playerPrefab;
    public float tiempoRenacer;

    public bool resInicio = false;

    void Awake()
    {
        playerInGame = GameObject.FindWithTag("Player");

    }

    void Start()
    {
        txVidas.text = vida.ToString();
        if (PlayerPrefs.GetInt("vidas") < 3)
        {
            Debug.Log(PlayerPrefs.GetInt("vidas"));
            Debug.Log("Calculando vidas");

            resInicio = true;

            AjustarVida();
        }
    }

    void Update()
    {

        if(vidaAnt != vida)
        {
            if (resInicio)
            {
                resInicio = false;
            }
            else
            {

                Destroy(imgVidas[vida]);
                Destroy(playerInGame);

            }

            vidaAnt = vida;
            txVidas.text = vida.ToString();

            StartCoroutine(Renacer());

        }

        if(vida == 0)
        {

            Debug.Log("Fin del juego");

            foreach (Image vid in imgVidas)
            {
                Destroy(vid);
                Destroy(gameObject);
            }
        }

    }

    void AjustarVida()
    {
        vida = PlayerPrefs.GetInt("vidas");

        txVidas.text = vida.ToString();

        switch (PlayerPrefs.GetInt("vidas"))
        {
            case 1:
                Destroy(imgVidas[1]);
                Destroy(imgVidas[2]);
                break;
            case 2:
                Destroy(imgVidas[2]);
                break;
        }

        /*for (int i = vida; i > 4; i++)
        {
            Destroy(imgVidas[i]);
        }*/


    }

    IEnumerator Renacer()
    {
        yield return new WaitForSeconds(tiempoRenacer);

        Instantiate(playerPrefab);
        Awake();
    }
}
