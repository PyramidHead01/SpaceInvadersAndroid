using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colBalaEnemiga : MonoBehaviour
{

    /*vidaPlayer vidaPlayer;
    
    void Awake()
    {
        vidaPlayer = GameObject.FindWithTag("Player").GetComponent<vidaPlayer>();
    }*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "BalaPlayer" || col.gameObject.tag == "SueloTecho" || col.gameObject.tag == "Muro")
        {

            /*if(col.gameObject.tag == "Player")
            {
                vidaPlayer.vida--;
                Destroy(gameObject);
            }
            else*/
                Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
