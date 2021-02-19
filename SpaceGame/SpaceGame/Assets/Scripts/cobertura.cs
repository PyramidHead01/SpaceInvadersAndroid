using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobertura : MonoBehaviour
{
    public GameObject mur2, mur3;

    void Start()
    {

        switch (Dificultad.niv)
        {
            case 2:
                Destroy(mur2);
                break;
            case 3:
                Destroy(mur2);
                Destroy(mur3);
                break;

        }

    }
}
