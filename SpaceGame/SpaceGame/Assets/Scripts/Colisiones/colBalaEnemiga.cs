using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colBalaEnemiga : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "BalaPlayer" || col.gameObject.tag == "SueloTecho")
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
