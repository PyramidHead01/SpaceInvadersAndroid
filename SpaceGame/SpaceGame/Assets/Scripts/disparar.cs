using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{

    public GameObject balaPlayer;
    public bool player = false;
    Transform transfObj;

    float contador = 5;

    void Start()
    {
        transfObj = this.GetComponent<Transform>();
    }

    void Update()
    {
        contador += Time.deltaTime;

        if (contador >= 1)
        {
            

            if(player)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GameObject bala = Instantiate(balaPlayer, transfObj.position, transfObj.rotation);
                    bala.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
                    contador = 0;
                }

            }               

            else
            {

                float i = Random.Range(0, 1f);
                if (i > 0.75)
                {

                    //Debug.Log(transfObj.position);
                    GameObject bala = Instantiate(balaPlayer, new Vector3(transfObj.position.x, (transfObj.position.y - 0.1f), transfObj.position.z), transfObj.rotation);
                    bala.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -10, 0);
                }
                contador = 0;
            }
                


        }
    }
}