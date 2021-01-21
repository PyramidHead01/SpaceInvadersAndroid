using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPlayer : MonoBehaviour
{

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
