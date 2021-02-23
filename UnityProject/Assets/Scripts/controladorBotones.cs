using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class controladorBotones : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pulsado;
    Rigidbody2D rb;
    public int lado;

    void Start()
    {
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        Start();

        pulsado = true;
     
        if(lado == 0)
        {
            rb.velocity = new Vector2(-5, 0);
        }
        else
        {
            rb.velocity = new Vector2(5, 0);
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }

}
