using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colEnemigo : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {

        }
        if (col.gameObject.tag == "BalaPlayer")
        {
            Debug.Log("asd");
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
