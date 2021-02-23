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


    void Awake()
    {
        playerInGame = GameObject.FindWithTag("Player");
       
    }

    void Start()
    {


        txVidas.text = vida.ToString();

    }

    void Update()
    {

        Debug.Log(vida);

        if(vidaAnt != vida)
        {

            Destroy(imgVidas[vida]);
            Destroy(playerInGame);

            vidaAnt = vida;
            txVidas.text = vida.ToString();

            StartCoroutine(Renacer());

        }

        if(vida <= 0)
        {

            Debug.Log("Fin del juego");

            foreach (Image vid in imgVidas)
            {
                Destroy(vid);
                Destroy(gameObject);
                txVidas.text = "0";
            }
        }

    }

    IEnumerator Renacer()
    {
        yield return new WaitForSeconds(tiempoRenacer);

        Instantiate(playerPrefab);
        Awake();
    }
}
