using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colBalaPlayer : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemigo" || col.gameObject.tag == "BalaEnemigo")
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
