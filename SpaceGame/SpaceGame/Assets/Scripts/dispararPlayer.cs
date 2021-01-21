using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispararPlayer : MonoBehaviour
{

    public GameObject balaPlayer;
    Transform player;

    float contador = 5;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        contador += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && contador >= 1)
        {
            GameObject bala = Instantiate(balaPlayer, player.position, player.rotation);
            bala.GetComponent<Rigidbody2D>().velocity = player.up * 10;
            contador = 0;
        }
    }
}