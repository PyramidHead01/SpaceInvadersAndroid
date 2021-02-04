using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneraOvni : MonoBehaviour
{

    public GameObject ovniPrefab;
    AudioSource efectosSonido;
    public AudioClip advise;
    public float contador;

    // Start is called before the first frame update
    void Awake()
    {
        efectosSonido = GameObject.FindWithTag("SonIdoEfectos").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        
        if(contador >= 30)
        {
            GameObject ovni = Instantiate(ovniPrefab, this.transform.position, this.transform.rotation);
            efectosSonido.PlayOneShot(advise);
            ovni.GetComponent<Rigidbody2D>().velocity = new Vector3(5, 0, 0);
            contador = 0;
        }

    }
}
