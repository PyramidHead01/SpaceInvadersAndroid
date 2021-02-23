using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorInicio : MonoBehaviour
{

    public void CargarJuego(int i)
    {

        Dificultad.niv = i;

        PlayerPrefs.SetInt("puntuacion", 0);

        SceneManager.LoadScene("Juego");
    }

}
