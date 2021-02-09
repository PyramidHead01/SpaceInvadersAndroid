using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorInicio : MonoBehaviour
{
    public void CargarJuego()
    {
        PlayerPrefs.SetInt("puntuacion", 0);
        PlayerPrefs.SetInt("vidas", 1);

        SceneManager.LoadScene("Juego");
    }

}
