using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colBalaPlayer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemigo" || col.gameObject.tag == "BalaEnemigo" || col.gameObject.tag == "SueloTecho")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
