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

        if(vidaAnt != vida)
        {

            vidaAnt = vida;
            txVidas.text = vida.ToString();

            Destroy(imgVidas[vida]);
            Destroy(playerInGame);

            StartCoroutine(Renacer());

        }   

        if(vida == 0)
        {
            foreach (Image vid in imgVidas)
            {
                Destroy(vid);
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
