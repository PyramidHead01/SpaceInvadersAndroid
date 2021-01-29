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

    // Start is called before the first frame update
    void Start()
    {
        txVidas.text = vida.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if(vida == 0)
        {
            Destroy(gameObject);
        }

        if(vidaAnt != vida)
        {

            vidaAnt = vida;
            txVidas.text = vida.ToString();

            Destroy(imgVidas[vida]);

        }   
    }
}
