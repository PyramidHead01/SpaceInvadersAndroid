using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class moverPlayer : MonoBehaviour
{

    public float speed = 5;
    Rigidbody2D rb;
    
    //Los controladores de los botones para moverse (esto no es en array porque peta)
     controladorBotones contrBotIzq;
     controladorBotones contrBotDer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        contrBotIzq = GameObject.FindWithTag("BotIzq").GetComponent<controladorBotones>();
        contrBotDer = GameObject.FindWithTag("BotDer").GetComponent<controladorBotones>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")){
            this.transform.position = new Vector3(this.transform.position.x + (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey("a"))
        {
            this.transform.position = new Vector3(this.transform.position.x - (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }

        if (contrBotIzq.pulsado == false && contrBotDer.pulsado == false)
            rb.velocity = Vector2.zero;



    }
}
